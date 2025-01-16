using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using TinyFx.AspNet;
using UGame.FuseService.Email.Consumers;
using UGame.FuseService.Email.Services;

namespace UGame.FuseService.Email;

/// <summary>
/// 邮件
/// </summary>
public class EmailStarup : ITinyFxHostingStartup
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="webApplicationBuilder"></param>
    public void ConfigureServices(WebApplicationBuilder webApplicationBuilder)
    {
        webApplicationBuilder.Services.AddSingleton<RedisService>();
        webApplicationBuilder.Services.AddSingleton<DepositService>();
        webApplicationBuilder.Services.AddSingleton<TaskRuleEnginer>();
        webApplicationBuilder.Services.AddSingleton<UserService>();
        webApplicationBuilder.Services.AddSingleton<EmailService>();
        webApplicationBuilder.Services.AddSingleton<EmailConsumer>();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="webApplication"></param>
    public void Configure(WebApplication webApplication)
    {
    }
}
