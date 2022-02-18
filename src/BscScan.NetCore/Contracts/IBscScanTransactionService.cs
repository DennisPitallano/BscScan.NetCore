using BscScan.NetCore.Models.Response.Transactions;

namespace BscScan.NetCore.Contracts
{
    /// <summary>
    ///  BscScan Transaction Module Interface
    /// </summary>
    public interface IBscScanTransactionService
    {
        /// <summary>
        /// Check Transaction Receipt Status
        /// </summary>
        /// <param name="txHash">the string representing the transaction hash to check the execution status</param>
        /// <returns>Returns the status code of a transaction execution.</returns>
        Task<TransactionReceiptStatus?> CheckTransactionReceiptStatus(string txHash);
    }
}
