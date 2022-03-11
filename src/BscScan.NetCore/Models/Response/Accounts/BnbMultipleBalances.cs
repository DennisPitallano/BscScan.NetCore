namespace BscScan.NetCore.Models.Response.Accounts;

/// <summary>
/// Bnb Multiple Balances Model
/// </summary>
public class BnbMultipleBalances : BaseResponse
{
    /// <summary>
    /// List of BnbMultipleBalanceData Result
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<BnbMultipleBalanceData>? Result { get; set; }
}

/// <summary>
/// Bnb Multiple Balance Data Model
/// </summary>
public class BnbMultipleBalanceData
{
    /// <summary>
    /// Account
    /// </summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>
    /// Balance
    /// </summary>
    [JsonPropertyName("balance")]
    public string? Balance { get; set; }
}