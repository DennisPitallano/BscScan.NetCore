using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Blocks
{
    /// <summary>
    /// DailyBlockCountAndRewards 
    /// </summary>
    public class DailyBlockCountAndRewards : BaseResponse
    {
        /// <summary>
        /// List of DailyBlockCountAndRewardsData
        /// </summary>
        [JsonPropertyName("result")]
        public IEnumerable<DailyBlockCountAndRewardsData>? Result { get; set; }
    }

    /// <summary>
    /// DailyBlockCountAndRewardsData 
    /// </summary>
    public class DailyBlockCountAndRewardsData
    {
        /// <summary>
        /// UTCDate
        /// </summary>
        [JsonPropertyName("UTCDate")]
        public string? UtcDate { get; set; }

        /// <summary>
        /// UnixTimeStamp
        /// </summary>
        [JsonPropertyName("unixTimeStamp")]
        public string? UnixTimeStamp { get; set; }

        /// <summary>
        /// BlockTimeSec
        /// </summary>
        [JsonPropertyName("blockTime_sec")]
        public string? BlockTimeSec { get; set; }
    }
}
