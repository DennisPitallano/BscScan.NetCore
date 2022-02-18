using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Blocks
{
    /// <summary>
    /// BlockRewards 
    /// </summary>
    public class BlockRewards : BaseResponse
    {
        /// <summary>
        /// BlockReward Data
        /// </summary>
        [JsonPropertyName("result")]
        public BlockRewardData? Result { get; set; }
    }

    /// <summary>
    /// BlockRewardData
    /// </summary>
    public class BlockRewardData
    {
        /// <summary>
        /// BlockNumber
        /// </summary>
        [JsonPropertyName("blockNumber")]
        public string? BlockNumber { get; set; }
        /// <summary>
        /// TimeStamp
        /// </summary>
        [JsonPropertyName("timeStamp")]
        public string? TimeStamp { get; set; }
        /// <summary>
        /// BlockMiner
        /// </summary>
        [JsonPropertyName("blockMiner")]
        public string? BlockMiner { get; set; }
        /// <summary>
        /// BlockReward
        /// </summary>
        [JsonPropertyName("blockReward")]
        public string? BlockReward { get; set; }
        /// <summary>
        /// Uncles
        /// </summary>
        [JsonPropertyName("uncles")]
        public List<string>? Uncles { get; set; }

        /// <summary>
        /// UncleInclusionReward
        /// </summary>
        [JsonPropertyName("uncleInclusionReward")]
        public string? UncleInclusionReward { get; set; }
    }


}
