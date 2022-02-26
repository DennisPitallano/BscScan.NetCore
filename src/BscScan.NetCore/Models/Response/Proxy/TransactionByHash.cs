using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Proxy
{
    /// <summary>
    /// TransactionByHash
    /// </summary>
    public class TransactionByHash
    {
        /// <summary>
        /// JsonRpc
        /// </summary>
        [JsonPropertyName("jsonrpc")]
        public string? JsonRpc { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [JsonPropertyName("result")]
        public TransactionByHashData? Result { get; set; }
    }

    /// <summary>
    /// TransactionByHashData
    /// </summary>
    public class TransactionByHashData
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
        /// from
        /// </summary>
        [JsonPropertyName("from")]
        public string? From { get; set; }
        /// <summary>
        /// gas
        /// </summary>
        [JsonPropertyName("gas")]
        public string? Gas { get; set; }
        /// <summary>
        /// gasPrice
        /// </summary>
        [JsonPropertyName("gasPrice")]
        public string? GasPrice { get; set; }
        /// <summary>
        /// hash
        /// </summary>
        [JsonPropertyName("hash")]
        public string? Hash { get; set; }
        /// <summary>
        /// input
        /// </summary>
        [JsonPropertyName("input")]
        public string? Input { get; set; }
        /// <summary>
        /// nonce
        /// </summary>
        [JsonPropertyName("nonce")]
        public string? Nonce { get; set; }
        /// <summary>
        /// to
        /// </summary>
        [JsonPropertyName("to")]
        public string? To { get; set; }
        /// <summary>
        /// transactionIndex
        /// </summary>
        [JsonPropertyName("transactionIndex")]
        public string? TransactionIndex { get; set; }
        /// <summary>
        /// value
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        /// <summary>
        /// type
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// v
        /// </summary>
        [JsonPropertyName("v")]
        public string? V { get; set; }
        /// <summary>
        /// r
        /// </summary>
        [JsonPropertyName("r")]
        public string? R { get; set; }
        /// <summary>
        /// s
        /// </summary>
        [JsonPropertyName("s")]
        public string? S { get; set; }
    }
}
