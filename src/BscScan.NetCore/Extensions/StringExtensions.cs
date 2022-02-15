namespace BscScan.NetCore.Extensions
{
    internal static class StringExtensions
    {

        public static string AppendApiKey(this string value, string? apiKey)
        {
            return value.Replace("{apiKey}", apiKey);
        }

        public static string AppendValue(this string query, string? value)
        {
            return query.Replace("{value}", value);
        }

        public static string AddQuery(this string query, string key, string value)
        {
            return query.EndsWith('&') ? $"{query}{key}={value}" : $"{query}&{key}={value}";
        }

        public static string AddQuery(this string query, string parameter)
        {
            return query.EndsWith('&') ? $"{query}{parameter}" : $"{query}&{parameter}";
        }


        public static string AddAction(this string query, string? action)
        {
            return query.EndsWith('&') ? $"{query}action={action}" : $"{query}&action={action}";
        }
    }
}
