namespace BscScan.NetCore.Models.Response.Accounts;

/// <summary>
/// Normal Transactions Model
/// </summary>
public class NormalTransactions : BaseResponse
{
    /// <summary>
    /// List of Normal Transaction Data
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<NormalTransactionData>? Result { get; set; }
}

/// <summary>
///  Normal Transaction Data Model
/// </summary>
public class NormalTransactionData
{
    /// <summary>
    /// BlockNumber
    /// </summary>
    [JsonPropertyName("blockNumber")]
    public string? BlockNumber { get; set; }

    /// <summary>
    /// TimesStamp
    /// </summary>
    [JsonPropertyName("timeStamp")]
    public string? TimesStamp { get; set; }

    /// <summary>
    /// Hash
    /// </summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary>
    /// Nonce
    /// </summary>
    [JsonPropertyName("nonce")]
    public string? Nonce { get; set; }

    /// <summary>
    /// BlockHash
    /// </summary>
    [JsonPropertyName("blockHash")]
    public string? BlockHash { get; set; }

    /// <summary>
    /// TransactionIndex
    /// </summary>
    [JsonPropertyName("transactionIndex")]
    public string? TransactionIndex { get; set; }

    /// <summary>
    /// From
    /// </summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>
    /// To
    /// </summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }

    /// <summary>
    /// Value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// Gas
    /// </summary>
    [JsonPropertyName("gas")]
    public string? Gas { get; set; }

    /// <summary>
    /// GasPrice
    /// </summary>
    [JsonPropertyName("gasPrice")]
    public string? GasPrice { get; set; }

    /// <summary>
    /// IsError
    /// </summary>
    [JsonPropertyName("isError")]
    public string? IsError { get; set; }

    /// <summary>
    /// TxReceiptStatus
    /// </summary>
    [JsonPropertyName("txreceipt_status")]
    public string? TxReceiptStatus { get; set; }

    /// <summary>
    /// Input
    /// </summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }

    /// <summary>
    /// ContractAddress
    /// </summary>
    [JsonPropertyName("contractAddress")]
    public string? ContractAddress { get; set; }

    /// <summary>
    /// CumulativeGasUsed
    /// </summary>
    [JsonPropertyName("cumulativeGasUsed")]
    public string? CumulativeGasUsed { get; set; }

    /// <summary>
    /// GasUsed
    /// </summary>
    [JsonPropertyName("gasUsed")]
    public string? GasUsed { get; set; }

    /// <summary>
    /// Confirmations
    /// </summary>
    [JsonPropertyName("confirmations")]
    public string? Confirmations { get; set; }
}