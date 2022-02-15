using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response
{
    public class BaseResponse
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
