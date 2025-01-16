using TinyFx.Configuration;
using UGame.FuseService.Banner.Extensions;

namespace UGame.FuseService.Banner.Utilities;

public class IconUtil
{
    public static string GetIcon(string icon)
    {
        var _options = ConfigUtil.GetSection<OptionsSection>();

        if (icon.StartsWith("http"))
            return icon;
        return _options.ImageBaseUrl + icon;
    }
}
