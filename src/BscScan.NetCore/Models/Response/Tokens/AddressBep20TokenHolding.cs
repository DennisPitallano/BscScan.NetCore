namespace BscScan.NetCore.Models.Response.Tokens;

/// <summary>
/// AddressBep20TokenHolding
/// </summary>
public class AddressBep20TokenHolding : BaseResponse
{
    /// <summary>
    /// List of AddressBep20TokenHoldingData
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<AddressBep20TokenHoldingData>? Result { get; set; }
}

/// <summary>
/// AddressBep20TokenHoldingData
/// </summary>
public class AddressBep20TokenHoldingData
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

    /// <summary>
    /// TokenDivisor
    /// </summary>
    [JsonPropertyName("TokenDivisor")]
    public string? TokenDivisor { get; set; }
}