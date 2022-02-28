using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Request.Proxy
{
    /// <summary>
    /// EthEstimateGasRequest
    /// </summary>
    public class EthEstimateGasRequest
    {
        /// <summary>
        /// data
        /// </summary>
        [JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// to
        /// </summary>
        [JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// value
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }

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
    }
}
