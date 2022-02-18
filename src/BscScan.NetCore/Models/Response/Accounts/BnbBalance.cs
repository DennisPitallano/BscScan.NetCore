using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Accounts;

public class BnbBalance : BaseResponse
{
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}