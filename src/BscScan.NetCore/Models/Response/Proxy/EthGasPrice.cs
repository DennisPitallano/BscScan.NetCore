using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Proxy
{
    /// <summary>
    /// EthGasPrice
    /// </summary>
    public class EthGasPrice
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
        public string? Result { get; set; }
    }
}
