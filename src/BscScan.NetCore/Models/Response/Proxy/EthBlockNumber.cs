using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Proxy
{
    /// <summary>
    /// EthBlockNumber Model
    /// </summary>
    public class EthBlockNumber
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
        public string? Id { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}
