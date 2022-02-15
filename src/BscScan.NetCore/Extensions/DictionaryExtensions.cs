namespace BscScan.NetCore.Extensions
{
    internal static class DictionaryExtensions
    {
        public static string ToQueryString(this IDictionary<string, string>? dictionary)
        {
            return dictionary != null ? string.Join("&", dictionary.Select(a => a.Key + "=" + a.Value)) : "";
        }

        public static string ToQueryString(this IDictionary<string, object?>? dictionary, string? moduleAction)
        {
            dictionary?.Add("action",moduleAction);
            return dictionary != null ? string.Join("&", dictionary.Select(a => a.Key + "=" + a.Value)) : "";
        }

    }
}
