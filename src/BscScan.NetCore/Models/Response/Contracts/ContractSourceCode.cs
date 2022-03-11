namespace BscScan.NetCore.Models.Response.Contracts;

/// <summary>
/// Contract Source Code Model
/// </summary>
public class ContractSourceCode : BaseResponse
{
    /// <summary>
    /// ContractSourceCodeData
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<ContractSourceCodeData>? Result { get; set; }
}

/// <summary>
/// ContractSourceCodeData
/// </summary>
public class ContractSourceCodeData
{
    /// <summary>
    /// SwarmSource
    /// </summary>
    [JsonPropertyName("SourceCode")]
    public string? SourceCode { get; set; }

    /// <summary>
    /// SwarmSource
    /// </summary>
    [JsonPropertyName("ABI")]
    public string? ABI { get; set; }

    /// <summary>
    /// SwarmSource
    /// </summary>
    [JsonPropertyName("ContractName")]
    public string? ContractName { get; set; }

    /// <summary>
    /// SwarmSource
    /// </summary>
    [JsonPropertyName("CompilerVersion")]
    public string? CompilerVersion { get; set; }

    /// <summary>
    /// SwarmSource
    /// </summary>
    [JsonPropertyName("OptimizationUsed")]
    public string? OptimizationUsed { get; set; }

    /// <summary>
    /// SwarmSource
    /// </summary>
    [JsonPropertyName("Runs")]
    public string? Runs { get; set; }

    /// <summary>
    /// SwarmSource
    /// </summary>
    [JsonPropertyName("ConstructorArguments")]
    public string? ConstructorArguments { get; set; }

    /// <summary>
    /// SwarmSource
    /// </summary>
    [JsonPropertyName("EVMVersion")]
    public string? EVMVersion { get; set; }

    /// <summary>
    /// SwarmSource
    /// </summary>
    [JsonPropertyName("Library")]
    public string? Library { get; set; }

    /// <summary>
    /// SwarmSource
    /// </summary>
    [JsonPropertyName("LicenseType")]
    public string? LicenseType { get; set; }

    /// <summary>
    /// SwarmSource
    /// </summary>
    [JsonPropertyName("Proxy")]
    public string? Proxy { get; set; }

    /// <summary>
    /// SwarmSource
    /// </summary>
    [JsonPropertyName("Implementation")]
    public string? Implementation { get; set; }

    /// <summary>
    /// SwarmSource
    /// </summary>
    [JsonPropertyName("SwarmSource")]
    public string? SwarmSource { get; set; }
}