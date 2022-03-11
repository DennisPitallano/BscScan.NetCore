namespace BscScan.NetCore.Models.Response.Blocks;

/// <summary>
/// DailyBlockCountAndRewards 
/// </summary>
public class DailyBlockRewards : BaseResponse
{
    /// <summary>
    /// List of DailyBlockCountAndRewardsData
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<DailyBlockRewardsData>? Result { get; set; }
}

/// <summary>
/// DailyBlockCountAndRewardsData 
/// </summary>
public class DailyBlockRewardsData
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
    /// BlockRewardsEth
    /// </summary>
    [JsonPropertyName("blockRewards_Eth")]
    public string? BlockRewardsEth { get; set; }
}