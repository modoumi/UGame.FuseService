using System.Collections.Generic;

namespace UGame.FuseService.Common.Core;

public static class DictionaryExtensions
{
    public static Dictionary<string, object> ToLowerKeys(this Dictionary<string, object> dict)
    {
        if (dict == null) return null;

        var result = new Dictionary<string, object>();
        foreach (var item in dict)
        {
            var newKey = item.Key.ToLower();
            result.Add(newKey, item.Value);
        }

        return result;
    }
}
