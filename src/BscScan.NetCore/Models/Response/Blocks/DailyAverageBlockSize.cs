using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Blocks;

/// <summary>
/// DailyAverageBlockSize Model
/// </summary>
public class DailyAverageBlockSize : BaseResponse
{
    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<DailyAverageBlockSizeData>? Result { get; set; }
}

/// <summary>
/// DailyAverageBlockSizeData
/// </summary>
public class DailyAverageBlockSizeData
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
    /// BlockSizeBytes
    /// </summary>
    [JsonPropertyName("blockSize_bytes")]
    public int BlockSizeBytes { get; set; }
}