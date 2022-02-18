using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Accounts;

public class BlocksValidated  : BaseResponse
{
    [JsonPropertyName("result")]
    public IEnumerable<BlocksValidatedData>? Result { get; set; }
}

public class BlocksValidatedData
{
    [JsonPropertyName("blockNumber")]
    public string? BlockNumber { get; set; }
    [JsonPropertyName("timeStamp")]
    public string? TimeStamp { get; set; }
    [JsonPropertyName("blockReward")]
    public string? BLockReward { get; set; }
}