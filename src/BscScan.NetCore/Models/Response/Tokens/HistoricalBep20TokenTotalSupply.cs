using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Tokens;

/// <summary>
/// HistoricalBep20TokenTotalSupply
/// </summary>
public class HistoricalBep20TokenTotalSupply : BaseResponse
{
    /// <summary>
    /// result
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}