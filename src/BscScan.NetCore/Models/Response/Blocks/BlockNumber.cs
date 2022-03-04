using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Blocks;

/// <summary>
/// BlockNumber Model
/// </summary>
public class BlockNumber : BaseResponse
{
    /// <summary>
    /// block number
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}