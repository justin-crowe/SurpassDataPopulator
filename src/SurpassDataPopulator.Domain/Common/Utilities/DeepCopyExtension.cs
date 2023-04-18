using System.Text.Json;

namespace SurpassDataPopulator.Domain.Common.Utilities;

public static class DeepCopyExtension
{
    public static T DeepCopyWithJsonSerialize<T>(this T obj)
    {
        //TODO dirty..
        return JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(obj));
    }
}