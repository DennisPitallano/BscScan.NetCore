namespace BscScan.NetCore.Models.Response.GasTracker;

/// <summary>
/// DailyAverageGasPrice
/// </summary>
public class DailyAverageGasPrice : BaseResponse
{
    /// <summary>
    /// List of DailyAverageGasPriceData
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<DailyAverageGasPriceData>? Result { get; set; }
}

/// <summary>
/// DailyAverageGasPriceData
/// </summary>
public class DailyAverageGasPriceData
{
    /// <summary>
    /// UTCDate
    /// </summary>
    [JsonPropertyName("UTCDate")]
    public string? UtcDate { get; set; }

    /// <summary>
    /// unixTimeStamp
    /// </summary>
    [JsonPropertyName("unixTimeStamp")]
    public string? UnixTimeStamp { get; set; }

    /// <summary>
    /// maxGasPrice_Wei
    /// </summary>
    [JsonPropertyName("maxGasPrice_Wei")]
    public string? MaxGasPriceWei { get; set; }

    /// <summary>
    /// minGasPrice_Wei
    /// </summary>
    [JsonPropertyName("minGasPrice_Wei")]
    public string? MinGasPriceWei { get; set; }

    /// <summary>
    /// avgGasPrice_Wei
    /// </summary>
    [JsonPropertyName("avgGasPrice_Wei")]
    public string? AvgGasPriceWei { get; set; }
}