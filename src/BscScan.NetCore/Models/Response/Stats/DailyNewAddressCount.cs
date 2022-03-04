using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Stats;

/// <summary>
/// 
/// </summary>
public class DailyNewAddressCount :BaseResponse
{
    /// <summary>
    /// List of DailyNetworkTransactionFeeData
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<DailyNewAddressCountData>? Result { get; set; }
}

/// <summary>
/// DailyNewAddressCountData
/// </summary>
public class DailyNewAddressCountData
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
    /// newAddressCount
    /// </summary>
    [JsonPropertyName("newAddressCount")]
    public string? NewAddressCount { get; set; }
}