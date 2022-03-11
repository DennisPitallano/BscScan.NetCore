namespace BscScan.NetCore.Models.Response.Blocks;

/// <summary>
/// DailyAverageTimeForBlock
/// </summary>
public class DailyAverageTimeForBlock: BaseResponse
{
    /// <summary>
    /// List of DailyBlockCountAndRewardsData
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<DailyAverageTimeForBlockData>? Result { get; set; }
}

/// <summary>
/// DailyBlockCountAndRewardsData 
/// </summary>
public class DailyAverageTimeForBlockData
{
    /// <summary>
    /// UTCDate
    /// </summary>
    [JsonPropertyName("UTCDate")]
    public string? UtcDate { get; set; }

    /// <summary>
    /// UnixTimeStamp
    /// </summary>
    [JsonPropertyName("unixTimeStamp")]
    public string? UnixTimeStamp { get; set; }

    /// <summary>
    /// BlockTimeSec
    /// </summary>
    [JsonPropertyName("blockTime_sec")]
    public string? BlockTimeSec { get; set; }
}