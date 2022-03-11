namespace BscScan.NetCore.Models.Response.Proxy;

/// <summary>
/// TransactionReceipt
/// </summary>
public class TransactionReceipt
{
    /// <summary>
    /// jsonrpc
    /// </summary>
    [JsonPropertyName("jsonrpc")]
    public string? JsonRpc { get; set; }

    /// <summary>
    /// id
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// result
    /// </summary>
    [JsonPropertyName("result")]
    public TransactionReceiptData? Result { get; set; }
}

/// <summary>
/// TransactionReceiptData
/// </summary>
public class TransactionReceiptData
{
    /// <summary>
    /// blockHash
    /// </summary>
    [JsonPropertyName("blockHash")]
    public string? BlockHash { get; set; }

    /// <summary>
    /// blockNumber
    /// </summary>
    [JsonPropertyName("blockNumber")]
    public string? BlockNumber { get; set; }

    /// <summary>
    /// contractAddress
    /// </summary>
    [JsonPropertyName("contractAddress")]
    public string? ContractAddress { get; set; }

    /// <summary>
    /// cumulativeGasUsed
    /// </summary>
    [JsonPropertyName("cumulativeGasUsed")]
    public string? CumulativeGasUsed { get; set; }

    /// <summary>
    /// from
    /// </summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>
    /// gasUsed
    /// </summary>
    [JsonPropertyName("gasUsed")]
    public string? GasUsed { get; set; }

    /// <summary>
    /// logs
    /// </summary>
    [JsonPropertyName("logs")]
    public IEnumerable<TransactionReceiptLog>? Logs { get; set; }

    /// <summary>
    /// logsBloom
    /// </summary>
    [JsonPropertyName("logsBloom")]
    public string? LogsBloom { get; set; }

    /// <summary>
    /// status
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// to
    /// </summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }

    /// <summary>
    /// transactionHash
    /// </summary>
    [JsonPropertyName("transactionHash")]
    public string? TransactionHash { get; set; }

    /// <summary>
    /// transactionIndex
    /// </summary>
    [JsonPropertyName("transactionIndex")]
    public string? TransactionIndex { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// TransactionReceiptLog
/// </summary>
public class TransactionReceiptLog
{
    /// <summary>
    /// address
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// topics
    /// </summary>
    [JsonPropertyName("topics")]
    public List<string>? Topics { get; set; }

    /// <summary>
    /// data
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>
    /// blockNumber
    /// </summary>
    [JsonPropertyName("blockNumber")]
    public string? BlockNumber { get; set; }

    /// <summary>
    /// transactionHash
    /// </summary>
    [JsonPropertyName("transactionHash")]
    public string? TransactionHash { get; set; }

    /// <summary>
    /// transactionIndex
    /// </summary>
    [JsonPropertyName("transactionIndex")]
    public string? TransactionIndex { get; set; }

    /// <summary>
    /// blockHash
    /// </summary>
    [JsonPropertyName("blockHash")]
    public string? BlockHash { get; set; }

    /// <summary>
    /// logIndex
    /// </summary>
    [JsonPropertyName("logIndex")]
    public string? LogIndex { get; set; }

    /// <summary>
    /// removed
    /// </summary>
    [JsonPropertyName("removed")]
    public bool Removed { get; set; }
}