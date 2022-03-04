using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Tokens;

/// <summary>
/// TokenCirculatingSupply
/// </summary>
public class TokenCirculatingSupply : BaseResponse
{
    /// <summary>
    /// result
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}