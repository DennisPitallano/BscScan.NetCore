using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Tokens
{
    /// <summary>
    /// AddressBep721TokenInventory
    /// </summary>
    public class AddressBep721TokenInventory : BaseResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [JsonPropertyName("result")]
        public IEnumerable<AddressBep721TokenInventoryData>? Result { get; set; }
    }

    /// <summary>
    /// AddressBep721TokenInventoryData
    /// </summary>
    public class AddressBep721TokenInventoryData
    {
        /// <summary>
        /// TokenAddress
        /// </summary>
        [JsonPropertyName("TokenAddress")]
        public string? TokenAddress { get; set; }
        /// <summary>
        /// TokenId
        /// </summary>
        [JsonPropertyName("TokenId")]
        public string? TokenId { get; set; }

    }
}
