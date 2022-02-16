using System.Text.Json;

namespace BscScan.NetCore.Extensions;

internal static class ObjectExtensions
{
    private static IDictionary<string, object>? ToDictionary(this object request)
    {
        var jsonFormat = request.ToJsonFormat();
        return JsonSerializer.Deserialize<Dictionary<string, object>>(jsonFormat);
    }

    private static string ToJsonFormat(this object obj)
    {
        return JsonSerializer.Serialize(obj);
    }

    internal static string? ToRequestParameters(this object request,string? moduleAction)
    {
        return request.ToDictionary()!.ToQueryString(moduleAction);
    }
}