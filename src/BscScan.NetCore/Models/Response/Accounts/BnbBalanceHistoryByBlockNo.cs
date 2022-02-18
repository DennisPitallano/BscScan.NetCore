using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Accounts;

public class BnbBalanceHistoryByBlockNo : BaseResponse
{
    [JsonPropertyName("result")]
    public IEnumerable<BnbBalanceHistoryByBlockNoData>? Result { get; set; }
}

public class BnbBalanceHistoryByBlockNoData
{
    [JsonPropertyName("account")]
    public string? Account { get; set; }
    [JsonPropertyName("balance")]
    public string? Balance { get; set; }
}