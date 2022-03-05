using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Stats;

/// <summary>
/// DailyNetworkUtilization
/// </summary>
public class DailyNetworkUtilization : BaseResponse
{
    /// <summary>
    /// result
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<DailyNetworkUtilizationData>? Result { get; set; }
}

/// <summary>
/// DailyNetworkUtilizationData
/// </summary>
public class DailyNetworkUtilizationData
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
    /// networkUtilization
    /// </summary>
    [JsonPropertyName("networkUtilization")]
    public string? NetworkUtilization { get; set; }
}