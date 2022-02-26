using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Proxy
{
    /// <summary>
    /// SendRawTransaction
    /// </summary>
    public class SendRawTransaction
    {
        /// <summary>
        /// JsonRpc
        /// </summary>
        [JsonPropertyName("jsonrpc")]
        public string? JsonRpc { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }


        /// <summary>
        /// Error
        /// </summary>
        [JsonPropertyName("error")]
        public Error? Error { get; set; }
    }

    /// <summary>
    /// Error
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Code
        /// </summary>
        [JsonPropertyName("Code")]
        public int Code { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
