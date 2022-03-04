using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Tokens;

/// <summary>
/// AddressBep721TokenHolding
/// </summary>
public class AddressBep721TokenHolding : BaseResponse
{
    /// <summary>
    /// result
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<AddressBep721TokenHoldingData>? Result { get; set; }
}

/// <summary>
/// 
/// </summary>
public class AddressBep721TokenHoldingData
{
    /// <summary>
    /// TokenAddress
    /// </summary>
    [JsonPropertyName("TokenAddress")]
    public string? TokenAddress { get; set; }

    /// <summary>
    /// TokenName
    /// </summary>
    [JsonPropertyName("TokenName")]
    public string? TokenName { get; set; }

    /// <summary>
    /// TokenSymbol
    /// </summary>
    [JsonPropertyName("TokenSymbol")]
    public string? TokenSymbol { get; set; }

    /// <summary>
    /// TokenQuantity
    /// </summary>
    [JsonPropertyName("TokenQuantity")]
    public string? TokenQuantity { get; set; }

}