namespace BscScan.NetCore.Models.Response.Accounts;

/// <summary>
/// Bnb Balance History ByBlock No
/// </summary>
public class BnbBalanceHistoryByBlockNo : BaseResponse
{
    /// <summary>
    /// List of  Bnb Balance History ByBlock No
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<BnbBalanceHistoryByBlockNoData>? Result { get; set; }
}

/// <summary>
/// Bnb Balance History By Block No Data Model
/// </summary>
public class BnbBalanceHistoryByBlockNoData
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