using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Contracts
{
    public class ContractSourceCode : BaseResponse
    {
        [JsonPropertyName("SourceCode")]
        public string? SourceCode { get; set; }
        [JsonPropertyName("ABI")]
        public string? ABI { get; set; }
        [JsonPropertyName("ContractName")]
        public string? ContractName { get; set; }
        [JsonPropertyName("CompilerVersion")]
        public string? CompilerVersion { get; set; }
        [JsonPropertyName("OptimizationUsed")]
        public string? OptimizationUsed { get; set; }
        [JsonPropertyName("Runs")]
        public string? Runs { get; set; }
        [JsonPropertyName("ConstructorArguments")]
        public string? ConstructorArguments { get; set; }
        [JsonPropertyName("EVMVersion")]
        public string? EVMVersion { get; set; }
        [JsonPropertyName("Library")]
        public string? Library { get; set; }
        [JsonPropertyName("LicenseType")]
        public string? LicenseType { get; set; }
        [JsonPropertyName("Proxy")]
        public string? Proxy { get; set; }
        [JsonPropertyName("Implementation")]
        public string? Implementation { get; set; }
        [JsonPropertyName("SwarmSource")]
        public string? SwarmSource { get; set; }
    }
}
