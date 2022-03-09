using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Blocks;

/// <summary>
/// DailyBlockCountAndRewards 
/// </summary>
public class DailyBlockCountAndRewards : BaseResponse
{
    /// <summary>
    /// List of DailyBlockCountAndRewardsData
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<DailyBlockCountAndRewardsData>? Result { get; set; }
}

/// <summary>
/// DailyBlockCountAndRewardsData 
/// </summary>
public class DailyBlockCountAndRewardsData
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
    /// blockCount
    /// </summary>
    [JsonPropertyName("blockCount")]
    public string? BlockCount { get; set; }

    /// <summary>
    /// blockRewards_Eth
    /// </summary>
    [JsonPropertyName("blockRewards_Eth")]
    public string? BlockRewardsEth { get; set; }
}