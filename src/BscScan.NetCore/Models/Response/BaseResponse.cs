using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response;

/// <summary>
/// 
/// </summary>
public class BaseResponse
{
    /// <summary>
    /// Status
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    /// <summary>
    /// Message
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}