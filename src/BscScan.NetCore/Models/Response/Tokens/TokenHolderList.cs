using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Tokens
{
    /// <summary>
    /// TokenHolderList
    /// </summary>
    public class TokenHolderList : BaseResponse
    {
        /// <summary>
        /// List of TokenHolderListItem
        /// </summary>
        [JsonPropertyName("result")]
        public IEnumerable<TokenHolderListItem>? Result { get; set; }
    }

    /// <summary>
    /// TokenHolderListItem
    /// </summary>
    public class TokenHolderListItem
    {
        /// <summary>
        /// TokenHolderAddress
        /// </summary>
        [JsonPropertyName("TokenHolderAddress")]
        public string? TokenHolderAddress { get; set; }

        /// <summary>
        /// TokenHolderQuantity
        /// </summary>
        [JsonPropertyName("TokenHolderQuantity")]
        public string? TokenHolderQuantity { get; set; }

    }
}
