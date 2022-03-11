namespace BscScan.NetCore.Models.Response.GasTracker;

/// <summary>
/// DailyAverageGasLimit
/// </summary>
public class DailyAverageGasLimit : BaseResponse
{
    /// <summary>
    /// List of DailyAverageGasLimitData
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<DailyAverageGasLimitData>? Result { get; set; }
}

/// <summary>
/// DailyAverageGasLimitData
/// </summary>
public class DailyAverageGasLimitData
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
    /// gasLimit
    /// </summary>
    [JsonPropertyName("gasLimit")]
    public string? GasLimit { get; set; }
}