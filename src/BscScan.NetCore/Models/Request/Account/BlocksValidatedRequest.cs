using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Request.Account
{
    public class BlocksValidatedRequest
    {
        /// <summary>
        /// the string pre-defined block type, 'blocks' for canonical blocks 
        /// </summary>
        /// <remarks>
        /// Optional if value is eq 'blocks'
        /// </remarks>
        [JsonPropertyName("blocktype")]
        public string BlockType { get; set; } = "blocks";

        /// <summary>
        /// the string representing the address to check for balance
        /// </summary>
        [JsonPropertyName("address")]
        public string? Address { get; set; }
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
