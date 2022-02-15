using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Account;

public  class BnbMultipleBalances : BaseResponse
{

    [JsonPropertyName("result")]
    public List<BnbMultipleBalanceData>? Result { get; set; }
}

public class BnbMultipleBalanceData
{
    [JsonPropertyName("account")]
    public string? Account { get; set; }
    [JsonPropertyName("balance")]
    public string? Balance { get; set; }
}