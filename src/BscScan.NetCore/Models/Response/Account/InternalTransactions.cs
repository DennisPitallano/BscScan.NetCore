using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Account;

public class InternalTransactionsByAddress: BaseResponse
{
    [JsonPropertyName("result")]
    public IEnumerable<InternalTransactionDataByAddress>? Result { get; set; }
}

public class InternalTransactionsByHash : BaseResponse
{
    [JsonPropertyName("result")]
    public IEnumerable<InternalTransactionDataByHash>? Result { get; set; }
}

public class InternalTransactionsByBlockRange : BaseResponse
{
    [JsonPropertyName("result")]
    public IEnumerable<InternalTransactionDataByBlockRange>? Result { get; set; }
}

public class InternalTransactionData
{
    [JsonPropertyName("blockNumber")]
    public string? BlockNumber { get; set; }
    [JsonPropertyName("timeStamp")]
    public string? TimesStamp { get; set; }
    [JsonPropertyName("from")]
    public string? From { get; set; }
    [JsonPropertyName("to")]
    public string? To { get; set; }
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    [JsonPropertyName("contractAddress")]
    public string? ContractAddress { get; set; }
    [JsonPropertyName("input")]
    public string? Input { get; set; }
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    [JsonPropertyName("gas")]
    public string? Gas { get; set; }
    [JsonPropertyName("gasUsed")]
    public string? GasUsed { get; set; }
    [JsonPropertyName("isError")]
    public string? IsError { get; set; }
    [JsonPropertyName("errCode")]
    public string? ErrCode { get; set; }
}

public class InternalTransactionDataByAddress : InternalTransactionData
{
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }
    [JsonPropertyName("traceId")]
    public string? TraceId { get; set; }
}

public class InternalTransactionDataByHash : InternalTransactionData
{
}

public class InternalTransactionDataByBlockRange : InternalTransactionData
{
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }
    [JsonPropertyName("traceId")]
    public string? TraceId { get; set; }
}