using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Tokens;

/// <summary>
/// TokenTotalSupply
/// </summary>
public class TokenTotalSupply : BaseResponse
{
    /// <summary>
    /// result
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}