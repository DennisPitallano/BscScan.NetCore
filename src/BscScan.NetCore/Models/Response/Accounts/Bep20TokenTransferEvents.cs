using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Accounts;

/// <summary>
/// Bep20 Token Transfer Events Model
/// </summary>
public class Bep20TokenTransferEvents : BaseResponse
{
    /// <summary>
    /// Bep20 Token Transfer Event Result Data Model
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<Bep20TokenTransferEventData>? Result { get; set; }
}

/// <summary>
/// Bep20 Token Transfer Event Result Data Model
/// </summary>
public class Bep20TokenTransferEventData
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
    /// From
    /// </summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }
    /// <summary>
    /// ContractAddress
    /// </summary>
    [JsonPropertyName("contractAddress")]
    public string? ContractAddress { get; set; }
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
    /// TokenName
    /// </summary>
    [JsonPropertyName("tokenName")]
    public string? TokenName { get; set; }
    /// <summary>
    /// TokenSymbol
    /// </summary>
    [JsonPropertyName("tokenSymbol")]
    public string? TokenSymbol { get; set; }
    /// <summary>
    /// TokenDecimal
    /// </summary>
    [JsonPropertyName("tokenDecimal")]
    public string? TokenDecimal { get; set; }
    /// <summary>
    /// TransactionIndex
    /// </summary>
    [JsonPropertyName("transactionIndex")]
    public string? TransactionIndex { get; set; }
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
    /// GasUsed
    /// </summary>
    [JsonPropertyName("gasUsed")]
    public string? GasUsed { get; set; }
    /// <summary>
    /// CumulativeGasUsed
    /// </summary>
    [JsonPropertyName("cumulativeGasUsed")]
    public string? CumulativeGasUsed { get; set; }
    /// <summary>
    /// Input
    /// </summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }
    /// <summary>
    /// Confirmations
    /// </summary>
    [JsonPropertyName("confirmations")]
    public string? Confirmations { get; set; }
}