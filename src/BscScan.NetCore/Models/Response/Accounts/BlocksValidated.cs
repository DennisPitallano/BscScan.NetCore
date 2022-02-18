using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Accounts;

/// <summary>
/// Blocks Validated
/// </summary>
public class BlocksValidated  : BaseResponse
{
    /// <summary>
    /// List of Blocks Validated
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<BlocksValidatedData>? Result { get; set; }
}

/// <summary>
/// Blocks Validated Data
/// </summary>
public class BlocksValidatedData
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
    /// BLockReward
    /// </summary>
    [JsonPropertyName("blockReward")]
    public string? BLockReward { get; set; }
}