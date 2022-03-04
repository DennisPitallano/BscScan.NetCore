using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Blocks;

/// <summary>
/// EstimatedBlockCountdownTime Model
/// </summary>
public  class EstimatedBlockCountdownTime : BaseResponse
{
    /// <summary>
    /// EstimatedBlockCountdownTimeData
    /// </summary>
    [JsonPropertyName("result")]
    public EstimatedBlockCountdownTimeData? Result { get; set; }
}

/// <summary>
/// EstimatedBlockCountdownTimeData Model
/// </summary>
public class EstimatedBlockCountdownTimeData
{

    /// <summary>
    /// CurrentBlock
    /// </summary>
    [JsonPropertyName("CurrentBlock")]
    public string? CurrentBlock { get; set; }

    /// <summary>
    /// CountdownBlock
    /// </summary>
    [JsonPropertyName("CountdownBlock")]
    public string? CountdownBlock { get; set; }

    /// <summary>
    /// RemainingBlock
    /// </summary>
    [JsonPropertyName("RemainingBlock")]
    public string? RemainingBlock { get; set; }

    /// <summary>
    /// EstimateTimeInSec
    /// </summary>
    [JsonPropertyName("EstimateTimeInSec")]
    public string? EstimateTimeInSec { get; set; }
}