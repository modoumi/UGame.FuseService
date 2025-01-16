using Microsoft.Extensions.Hosting;

namespace UGame.FuseService.Banner.Extensions;

public static class BuilderExtensions
{
    public static IHostBuilder UseLobbyServer(this IHostBuilder builder)
    {
        builder.UseXxyyCommonServer<OptionsSection>();
        return builder;
    }
}
