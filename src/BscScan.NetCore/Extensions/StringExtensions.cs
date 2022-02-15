namespace BscScan.NetCore.Extensions
{
    internal static class StringExtensions
    {

        public static string AppendApiKey(this string value, string? apiKey)
        {
            return value.Replace("{apiKey}", apiKey);
        }

        public static string AddAction(this string url,string? action)
        {
            return $"{url}&action={action}";
        }
    }
}
