using Microsoft.Extensions.Configuration;
using Xxyy.Common;

namespace UGame.FuseService.Marquee.Extensions;

/// <summary>
/// 
/// </summary>
public class OptionsSection : AppSectionBase
{
    #region 环境变量可配置

    private const string ENV_ImageBaseUrl = "ENV_ImageBaseUrl";
        
    /// <summary>
    /// 优先级：环境变量ENV_ImageBaseUrl > 配置文件
    /// </summary>
    public string ImageBaseUrl { get; set; }

    #endregion

    /// <summary>
    /// 
    /// </summary>
    /// <param name="configuration"></param>
    public override void Bind(IConfiguration configuration)
    {
        base.Bind(configuration);

        // ImageBaseUrl
        var imageBaseUrl = Environment.GetEnvironmentVariable(ENV_ImageBaseUrl);

        if (!string.IsNullOrEmpty(imageBaseUrl)) ImageBaseUrl = imageBaseUrl;
    }
}
