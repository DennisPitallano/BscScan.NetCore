namespace BscScan.NetCore.Models.Response.Tokens;

/// <summary>
/// 
/// </summary>
public class HistoricalBep20TokenAccountBalance : BaseResponse
{
    /// <summary>
    /// result
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}