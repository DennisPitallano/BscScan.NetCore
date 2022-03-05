using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Stats;

/// <summary>
/// DailyTransactionCount 
/// </summary>
public class DailyTransactionCount : BaseResponse
{
    /// <summary>
    /// List of DailyTransactionCountData
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<DailyTransactionCountData>? Result { get; set; }
}

/// <summary>
/// DailyTransactionCountData
/// </summary>
public class DailyTransactionCountData
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
    /// transactionCount
    /// </summary>
    [JsonPropertyName("transactionCount")]
    public int TransactionCount { get; set; }
}