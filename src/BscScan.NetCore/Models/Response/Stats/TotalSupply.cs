using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Stats
{
    /// <summary>
    /// TotalSupply
    /// </summary>
    public class TotalSupply : BaseResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}
