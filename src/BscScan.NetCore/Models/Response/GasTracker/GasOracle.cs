using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.GasTracker;

/// <summary>
/// GasOracle
/// </summary>
public class GasOracle : BaseResponse
{
    /// <summary>
    /// GasOracleData
    /// </summary>
    [JsonPropertyName("result")]
    public GasOracleData? Result { get; set; }
}

/// <summary>
/// GasOracleData
/// </summary>
public class GasOracleData
{
    /// <summary>
    /// LastBlock
    /// </summary>
    [JsonPropertyName("LastBlock")]
    public string? LastBlock { get; set; }

    /// <summary>
    /// SafeGasPrice
    /// </summary>
    [JsonPropertyName("SafeGasPrice")]
    public string? SafeGasPrice { get; set; }

    /// <summary>
    /// ProposeGasPrice
    /// </summary>
    [JsonPropertyName("ProposeGasPrice")]
    public string? ProposeGasPrice { get; set; }

    /// <summary>
    /// FastGasPrice
    /// </summary>
    [JsonPropertyName("FastGasPrice")]
    public string? FastGasPrice { get; set; }

    /// <summary>
    /// UsdPrice
    /// </summary>
    [JsonPropertyName("UsdPrice")]
    public string? UsdPrice { get; set; }
}