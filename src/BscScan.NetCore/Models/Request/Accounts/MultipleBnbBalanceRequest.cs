using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Request.Accounts;

public  class MultipleBnbBalanceRequest
{
    /// <summary>
    /// the strings representing the addresses to check for balance, separated by , commas up to 20 addresses per call
    /// </summary>
    [JsonIgnore]
    public string[]? Addresses { get; set; }
    /// <summary>
    /// the string pre-defined block parameter, either earliest, pending or latest
    /// (latest is the default value)
    /// </summary>
    /// <code>Optional</code>
    [JsonIgnore]
    public Tag Tag { get; set; } = Tag.Latest;

    [JsonPropertyName("tag")]
    public string TagParam => Tag.ToString().ToLower();

    [JsonPropertyName("address")]
    public string Address => string.Join(",", Addresses ?? Array.Empty<string>());
}