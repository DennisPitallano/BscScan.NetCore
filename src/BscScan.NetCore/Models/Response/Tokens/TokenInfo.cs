using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Tokens
{
    /// <summary>
    /// TokenInfo
    /// </summary>
    public class TokenInfo : BaseResponse
    {
        /// <summary>
        /// List of TokenInfoData
        /// </summary>
        [JsonPropertyName("result")]
        public IEnumerable<TokenInfoData>? Result { get; set; }
    }

    /// <summary>
    /// TokenInfoData
    /// </summary>
    public class TokenInfoData
    {
        /// <summary>
        /// contractAddress
        /// </summary>
        [JsonPropertyName("contractAddress")]
        public string? ContractAddress { get; set; }
        /// <summary>
        /// tokenName
        /// </summary>
        [JsonPropertyName("tokenName")]
        public string? TokenName { get; set; }
        /// <summary>
        /// symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
        /// <summary>
        /// divisor
        /// </summary>
        [JsonPropertyName("divisor")]
        public string? Divisor { get; set; }
        /// <summary>
        /// tokenType
        /// </summary>
        [JsonPropertyName("tokenType")]
        public string? TokenType { get; set; }
        /// <summary>
        /// totalSupply
        /// </summary>
        [JsonPropertyName("totalSupply")]
        public string? TotalSupply { get; set; }
        /// <summary>
        /// blueCheckmark
        /// </summary>
        [JsonPropertyName("blueCheckmark")]
        public string? BlueCheckmark { get; set; }
        /// <summary>
        /// description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        /// <summary>
        /// website
        /// </summary>
        [JsonPropertyName("website")]
        public string? Website { get; set; }
        /// <summary>
        /// website
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        /// <summary>
        /// blog
        /// </summary>
        [JsonPropertyName("blog")]
        public string? Blog { get; set; }
        /// <summary>
        /// reddit
        /// </summary>
        [JsonPropertyName("reddit")]
        public string? Reddit { get; set; }
        /// <summary>
        /// slack
        /// </summary>
        [JsonPropertyName("slack")]
        public string? Slack { get; set; }
        /// <summary>
        /// facebook
        /// </summary>
        [JsonPropertyName("facebook")]
        public string? Facebook { get; set; }
        /// <summary>
        /// twitter
        /// </summary>
        [JsonPropertyName("twitter")]
        public string? Twitter { get; set; }
        /// <summary>
        /// bitcointalk
        /// </summary>
        [JsonPropertyName("bitcointalk")]
        public string? BitcoinTalk { get; set; }
        /// <summary>
        /// github
        /// </summary>
        [JsonPropertyName("github")]
        public string? Github { get; set; }
        /// <summary>
        /// telegram
        /// </summary>
        [JsonPropertyName("telegram")]
        public string? Telegram { get; set; }
        /// <summary>
        /// wechat
        /// </summary>
        [JsonPropertyName("wechat")]
        public string? WeChat { get; set; }
        /// <summary>
        /// linkedin
        /// </summary>
        [JsonPropertyName("linkedin")]
        public string? LinkedIn { get; set; }
        /// <summary>
        /// discord
        /// </summary>
        [JsonPropertyName("discord")]
        public string? Discord { get; set; }
        /// <summary>
        /// whitepaper
        /// </summary>
        [JsonPropertyName("whitepaper")]
        public string? WhitePaper { get; set; }
        /// <summary>
        /// tokenPriceUSD
        /// </summary>
        [JsonPropertyName("tokenPriceUSD")]
        public string? TokenPriceUsd { get; set; }
    }
}
