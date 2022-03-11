namespace BscScan.NetCore.Models.Response.GasTracker;

/// <summary>
/// BnbSmartChainDailyTotalGasUsed
/// </summary>
public class BnbSmartChainDailyTotalGasUsed : BaseResponse
{
    /// <summary>
    /// List of BnbSmartChainDailyTotalGasUsedData
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<BnbSmartChainDailyTotalGasUsedData>? Result { get; set; }
}

/// <summary>
/// BnbSmartChainDailyTotalGasUsedData
/// </summary>
public class BnbSmartChainDailyTotalGasUsedData
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
    [JsonPropertyName("gasUsed")]
    public string? GasUsed { get; set; }
}