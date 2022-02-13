using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response;

public class BnbBalance
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    [JsonPropertyName("message")]
    public string? Message { get; set; }
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}