using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Stats
{
    /// <summary>
    /// BnbLastPrice
    /// </summary>
    public class BnbLastPrice : BaseResponse
    {
        /// <summary>
        /// BnbLastPriceData
        /// </summary>
        [JsonPropertyName("result")]
        public BnbLastPriceData? Result { get; set; }
    }

    /// <summary>
    /// BnbLastPriceData
    /// </summary>
    public class BnbLastPriceData
    {
        /// <summary>
        /// ethbtc
        /// </summary>
        [JsonPropertyName("ethbtc")]
        public string? EthBtc { get; set; }

        /// <summary>
        /// ethbtc_timestamp
        /// </summary>
        [JsonPropertyName("ethbtc_timestamp")]
        public string? EthBtcTimestamp { get; set; }

        /// <summary>
        /// ethusd
        /// </summary>
        [JsonPropertyName("ethusd")]
        public string? EthUsd { get; set; }

        /// <summary>
        /// ethusd_timestamp
        /// </summary>
        [JsonPropertyName("ethusd_timestamp")]
        public string? EthUsdTimestamp { get; set; }
    }
}
