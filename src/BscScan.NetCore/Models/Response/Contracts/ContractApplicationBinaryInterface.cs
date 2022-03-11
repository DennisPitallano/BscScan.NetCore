namespace BscScan.NetCore.Models.Response.Contracts;

/// <summary>
/// Contract Application Binary Interface
/// </summary>
public class ContractApplicationBinaryInterface : BaseResponse
{
    /// <summary>
    /// Result
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}