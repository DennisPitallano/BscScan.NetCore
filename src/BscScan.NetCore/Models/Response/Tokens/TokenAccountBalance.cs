namespace BscScan.NetCore.Models.Response.Tokens;

/// <summary>
/// TokenAccountBalance
/// </summary>
public class TokenAccountBalance : BaseResponse
{
    /// <summary>
    /// result
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}