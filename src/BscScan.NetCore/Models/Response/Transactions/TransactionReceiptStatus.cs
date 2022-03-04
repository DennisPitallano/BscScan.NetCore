using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Transactions;

/// <summary>
/// Transaction Receipt Status Model
/// </summary>
public class TransactionReceiptStatus : BaseResponse
{
    /// <summary>
    /// Transaction Receipt Status Result Data
    /// </summary>
    [JsonPropertyName("result")]
    public TransactionReceiptStatusData? Result { get; set; }
}

/// <summary>
/// Transaction Receipt Status Data
/// </summary>
public class TransactionReceiptStatusData
{
    /// <summary>
    /// The status field returns 0 for failed transactions and 1 for successful transactions
    /// </summary>
    public bool Status => NumericStatus == "1";

    /// <summary>
    /// NumericStatus
    /// </summary>
    [JsonPropertyName("status")]
    public string NumericStatus { get; set; } = "0";
}