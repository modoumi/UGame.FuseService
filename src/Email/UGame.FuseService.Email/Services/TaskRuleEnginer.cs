using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TinyFx;
using UGame.FuseService.Email.Models;

namespace UGame.FuseService.Email.Services;

/// <summary>
/// 
/// </summary>
public class TaskRuleEnginer
{
    private readonly Dictionary<int, RuleRunner> ruleRunners = new();
    private readonly CancellationTokenSource cancellationSource = new();
    //最多允许200个并发同时获取规则表达式解析委托，多余的线程阻塞中
    private readonly BlockingCollection<RuleEnginerMessage> messageQueue = new(200);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="logger"></param>
    public TaskRuleEnginer(ILogger<TaskRuleEnginer> logger)
    {
        var task = Task.Factory.StartNew(() =>
        {
            while (!this.cancellationSource.IsCancellationRequested)
            {
                try
                {
                    if (this.messageQueue.TryTake(out var message))
                    {
                        if (!this.ruleRunners.TryGetValue(message.HashKey, out var ruleRunner))
                        {
                            var options = ScriptOptions.Default
                                .WithEmitDebugInformation(false)
                                .AddReferences(typeof(DateTime).Assembly, typeof(RuleEngineParameter).Assembly)
                                .WithImports("System", "UGame.FuseService.Email.Models");

                            Script<bool> runnerScript = null;
                            if (string.IsNullOrEmpty(message.Statement))
                                runnerScript = CSharpScript.Create<bool>("true", options: options, globalsType: typeof(RuleEngineParameter));
                            else runnerScript = CSharpScript.Create<bool>(message.Statement, options: options, globalsType: typeof(RuleEngineParameter));

                            this.ruleRunners.TryAdd(message.HashKey, ruleRunner = new RuleRunner
                            {
                                ConditionExpr = message.Statement,
                                ScriptRunner = runnerScript.CreateDelegate()
                            });
                        }
                        message.Waiter.TrySetResult(ruleRunner);
                    }
                    else Thread.Sleep(1);
                }
                catch (Exception ex)
                {
                    var exception = ex.InnerException ?? ex;
                    logger.LogError("TaskRuleEnginer,获取规则表达式解析委托异常");
                }
            }
        }, this.cancellationSource.Token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="hashKey"></param>
    /// <param name="statement"></param>
    /// <returns></returns>
    public async Task<RuleRunner> GetRuleRunnerAsync(int hashKey, string statement)
    {
        var message = new RuleEnginerMessage
        {
            HashKey = hashKey,
            Statement = statement,
            Waiter = new TaskCompletionSource<RuleRunner>()
        };
        this.messageQueue.Add(message);
        return await message.Waiter.Task;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="hashKey"></param>
    /// <param name="statement"></param>
    /// <param name="engineParameter"></param>
    /// <returns></returns>
    public async Task<bool> Execute(int hashKey, string statement, RuleEngineParameter engineParameter)
    {
        //没有规则，直接返回true
        if (string.IsNullOrEmpty(statement)) return true;

        var ruleRunner = await this.GetRuleRunnerAsync(hashKey, statement);

        if (statement.Contains("User") && engineParameter.User == null)
        {
            var userService = DIUtil.GetService<UserService>();
            await userService.Get(engineParameter);
        }
        if (statement.Contains("Referrer") && engineParameter.Referrer == null)
        {
            var userService = DIUtil.GetService<UserService>();
            await userService.GetReferrer(engineParameter);
        }
        if (statement.Contains("TotalDepositAmountDaily") && !engineParameter.TotalDepositAmountDaily.HasValue)
        {
            var depositService = DIUtil.GetService<DepositService>();
            engineParameter.TotalDepositAmountDaily = await depositService.GetTotalDepositAmountDaily(engineParameter);
        }
        if (statement.Contains("TotalDepositAmountWeekly") && !engineParameter.TotalDepositAmountWeekly.HasValue)
        {
            var depositService = DIUtil.GetService<DepositService>();
            engineParameter.TotalDepositAmountWeekly = await depositService.GetTotalDepositAmountWeekly(engineParameter);
        }
        if (statement.Contains("TotalDepositAmountMonthly") && !engineParameter.TotalDepositAmountMonthly.HasValue)
        {
            var depositService = DIUtil.GetService<DepositService>();
            engineParameter.TotalDepositAmountMonthly = await depositService.GetTotalDepositAmountMonthly(engineParameter);
        }
        return await ruleRunner.ScriptRunner.Invoke(engineParameter);
    }

    /// <summary>
    /// 
    /// </summary>
    struct RuleEnginerMessage
    {
        public int HashKey { get; set; }

        public string Statement { get; set; }

        public TaskCompletionSource<RuleRunner> Waiter { get; set; }
    }
}

/// <summary>
/// 
/// </summary>
public class RuleRunner
{
    /// <summary>
    /// 条件表达式
    /// </summary>
    public string ConditionExpr { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ScriptRunner<bool> ScriptRunner { get; set; }
}
