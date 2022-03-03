using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Request.Tokens
{
    /// <summary>
    /// AddressBep20TokenHoldingRequest
    /// </summary>
    public class AddressBep20TokenHoldingRequest
    {
        /// <summary>
        /// the contract address of the BEP-20 token
        /// </summary>
        [JsonPropertyName("contractaddress")]
        public string? ContractAddress { get; set; }
        /// <summary>
        /// the integer page number, if pagination is enabled (default is 1)
        /// </summary>
        [JsonPropertyName("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// the number of transactions displayed per page (default is 10)
        /// </summary>
        [JsonPropertyName("offset")]
        public int OffSet { get; set; } = 10;
    }
}
