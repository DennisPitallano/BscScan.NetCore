using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Account;

public class BnbBalance : BaseResponse
{
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}