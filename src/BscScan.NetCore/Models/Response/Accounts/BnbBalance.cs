using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Accounts;

/// <summary>
/// Bnb Balance
/// </summary>
public class BnbBalance : BaseResponse
{
    /// <summary>
    /// Result
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}