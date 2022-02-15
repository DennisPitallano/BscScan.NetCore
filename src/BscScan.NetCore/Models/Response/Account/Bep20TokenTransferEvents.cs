using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Account
{
    public class Bep20TokenTransferEvents : BaseResponse
    {
        [JsonPropertyName("result")]
        public List<Bep20TokenTransferEventData>? Result { get; set; }
    }

    public class Bep20TokenTransferEventData
    {
        [JsonPropertyName("blockNumber")]
        public string? BlockNumber { get; set; }
        [JsonPropertyName("timeStamp")]
        public string? TimesStamp { get; set; }
        [JsonPropertyName("hash")]
        public string? Hash { get; set; }
        [JsonPropertyName("nonce")]
        public string? Nonce { get; set; }
        [JsonPropertyName("blockHash")]
        public string? BlockHash { get; set; }
        [JsonPropertyName("from")]
        public string? From { get; set; }
        [JsonPropertyName("contractAddress")]
        public string? ContractAddress { get; set; }
        [JsonPropertyName("to")]
        public string? To { get; set; }
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        [JsonPropertyName("tokenName")]
        public string? TokenName { get; set; }
        [JsonPropertyName("tokenSymbol")]
        public string? TokenSymbol { get; set; }
        [JsonPropertyName("tokenDecimal")]
        public string? TokenDecimal { get; set; }
        [JsonPropertyName("transactionIndex")]
        public string? TransactionIndex { get; set; }
        [JsonPropertyName("gas")]
        public string? Gas { get; set; }
        [JsonPropertyName("gasPrice")]
        public string? GasPrice { get; set; }
        [JsonPropertyName("gasUsed")]
        public string? GasUsed { get; set; }
        [JsonPropertyName("cumulativeGasUsed")]
        public string? CumulativeGasUsed { get; set; }
        [JsonPropertyName("input")]
        public string? Input { get; set; }
        [JsonPropertyName("confirmations")]
        public string? Confirmations { get; set; }
    }
}
