using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.Extensions.DependencyInjection;
using SComms.Email.Core;
using SComms.Email.Models;
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace SComms.Email.Services;

public class TaskRuleEnginer
{
    private readonly IServiceProvider serviceProvider = GlobalServiceProvider.ServiceProvider;
    private readonly ConcurrentDictionary<int, RuleRunner> ruleRunners = new();

    public async Task<bool> Execute(int hashKey, string statement, RuleEngineParameter engineParameter)
    {
        if (!this.ruleRunners.TryGetValue(hashKey, out var ruleRunner)
            && ruleRunner.ConditionExpr != statement)
        {
            var options = ScriptOptions.Default
               .AddReferences(typeof(DateTime).Assembly, typeof(RuleEngineParameter).Assembly)
               .WithImports("System", "SComms.Email.Models");

            Script<bool> runnerScript = null;
            if (string.IsNullOrEmpty(statement))
                runnerScript = CSharpScript.Create<bool>("true", options: options, globalsType: typeof(RuleEngineParameter));
            else runnerScript = CSharpScript.Create<bool>(statement, options: options, globalsType: typeof(RuleEngineParameter));

            ruleRunner = new RuleRunner
            {
                ConditionExpr = statement,
                ScriptRunner = runnerScript.CreateDelegate()
            };
            this.ruleRunners.AddOrUpdate(hashKey, ruleRunner, (key, old) => ruleRunner);
        }
        if (statement.Contains("User") && engineParameter.User == null)
        {
            var userService = this.serviceProvider.GetService<UserService>();
            await userService.Get(engineParameter);
        }
        if (statement.Contains("Referrer") && engineParameter.Referrer == null)
        {
            var userService = this.serviceProvider.GetService<UserService>();
            await userService.GetReferrer(engineParameter);
        }
        if (statement.Contains("TotalDepositAmountDaily") && !engineParameter.TotalDepositAmountDaily.HasValue)
        {
            var depositService = this.serviceProvider.GetService<DepositService>();
            engineParameter.TotalDepositAmountDaily = await depositService.GetTotalDepositAmountDaily(engineParameter);
        }
        if (statement.Contains("TotalDepositAmountWeekly") && !engineParameter.TotalDepositAmountWeekly.HasValue)
        {
            var depositService = this.serviceProvider.GetService<DepositService>();
            engineParameter.TotalDepositAmountWeekly = await depositService.GetTotalDepositAmountWeekly(engineParameter);
        }
        if (statement.Contains("TotalDepositAmountMonthly") && !engineParameter.TotalDepositAmountMonthly.HasValue)
        {
            var depositService = this.serviceProvider.GetService<DepositService>();
            engineParameter.TotalDepositAmountMonthly = await depositService.GetTotalDepositAmountMonthly(engineParameter);
        }
        return await ruleRunner.ScriptRunner.Invoke(engineParameter);
    }
}
class RuleRunner
{
    public string ConditionExpr { get; set; }
    public ScriptRunner<bool> ScriptRunner { get; set; }
}
