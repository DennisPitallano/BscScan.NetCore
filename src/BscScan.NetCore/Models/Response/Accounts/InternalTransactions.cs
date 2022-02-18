using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Accounts;

/// <summary>
/// Internal Transactions By Address Model
/// </summary>
public class InternalTransactionsByAddress: BaseResponse
{
    /// <summary>
    /// List of Internal Transaction Data By Address 
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<InternalTransactionDataByAddress>? Result { get; set; }
}

/// <summary>
/// 
/// </summary>
public class InternalTransactionsByHash : BaseResponse
{
    /// <summary>
    /// List Internal Transaction Data By Hash
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<InternalTransactionDataByHash>? Result { get; set; }
}

/// <summary>
/// Internal Transactions By Block Range Model
/// </summary>
public class InternalTransactionsByBlockRange : BaseResponse
{
    /// <summary>
    /// List of Internal Transaction Data By Block Range
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<InternalTransactionDataByBlockRange>? Result { get; set; }
}

/// <summary>
/// Internal Transaction Data Model
/// </summary>
public class InternalTransactionData
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
    /// ContractAddress
    /// </summary>
    [JsonPropertyName("contractAddress")]
    public string? ContractAddress { get; set; }
    /// <summary>
    /// Input
    /// </summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }
    /// <summary>
    /// Type
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    /// <summary>
    /// Gas
    /// </summary>
    [JsonPropertyName("gas")]
    public string? Gas { get; set; }
    /// <summary>
    /// GasUsed
    /// </summary>
    [JsonPropertyName("gasUsed")]
    public string? GasUsed { get; set; }
    /// <summary>
    /// IsError
    /// </summary>
    [JsonPropertyName("isError")]
    public string? IsError { get; set; }
    /// <summary>
    /// ErrCode
    /// </summary>
    [JsonPropertyName("errCode")]
    public string? ErrCode { get; set; }
}

/// <summary>
/// Internal Transaction Data By Address Model
/// </summary>
public class InternalTransactionDataByAddress : InternalTransactionData
{
    /// <summary>
    /// Hash
    /// </summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }
    /// <summary>
    /// TraceId
    /// </summary>
    [JsonPropertyName("traceId")]
    public string? TraceId { get; set; }
}

/// <summary>
/// Internal Transaction Data By Hash Model
/// </summary>
public class InternalTransactionDataByHash : InternalTransactionData
{
}

/// <summary>
/// Internal Transaction Data By Block Range
/// </summary>
public class InternalTransactionDataByBlockRange : InternalTransactionData
{
    /// <summary>
    /// Hash
    /// </summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }
    /// <summary>
    /// TraceId
    /// </summary>
    [JsonPropertyName("traceId")]
    public string? TraceId { get; set; }
}