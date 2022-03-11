namespace BscScan.NetCore.Models.Response.Stats;

/// <summary>
/// DailyNetworkTransactionFee
/// </summary>
public class DailyNetworkTransactionFee : BaseResponse
{
    /// <summary>
    /// List of DailyNetworkTransactionFeeData
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<DailyNetworkTransactionFeeData>? Result { get; set; }
}

/// <summary>
/// DailyNetworkTransactionFeeData
/// </summary>
public class DailyNetworkTransactionFeeData
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
    /// transactionFee_Eth
    /// </summary>
    [JsonPropertyName("transactionFee_Eth")]
    public string? TransactionFeeEth { get; set; }
}