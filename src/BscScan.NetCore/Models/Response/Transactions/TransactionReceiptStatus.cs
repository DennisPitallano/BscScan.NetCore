using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Transactions
{
    public class TransactionReceiptStatus : BaseResponse
    {
        [JsonPropertyName("result")]
        public TransactionReceiptStatusData? Result { get; set; }
    }

    public class TransactionReceiptStatusData
    {
        /// <summary>
        /// The status field returns 0 for failed transactions and 1 for successful transactions
        /// </summary>
        public bool Status => NumericStatus == "1";

        [JsonPropertyName("status")]
        public string NumericStatus { get; set; } = "0";
    }
}
