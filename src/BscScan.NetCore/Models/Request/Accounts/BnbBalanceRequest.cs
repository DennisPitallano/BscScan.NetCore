using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Request.Accounts;

/// <summary>
/// 
/// </summary>
public class BnbBalanceRequest
{
    /// <summary>
    /// the string representing the address to check for balance
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// the string pre-defined block parameter, either earliest, pending or latest
    /// (latest is the default value)
    /// </summary>
    /// <code>Optional</code>
    [JsonIgnore]
    public Tag Tag { get; set; } = Tag.Latest;

    /// <summary>
    /// the string pre-defined block parameter, either earliest, pending or latest
    /// (latest is the default value)
    /// </summary>
    /// <code>Optional</code>
    [JsonPropertyName("tag")]
    public string TagParam => Tag.ToString().ToLower();
}