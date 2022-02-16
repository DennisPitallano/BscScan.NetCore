using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Contracts
{
    public class ContractApplicationBinaryInterface : BaseResponse
    {
        [JsonPropertyName("result")]
        public string?  Result { get; set; }
    }
}
