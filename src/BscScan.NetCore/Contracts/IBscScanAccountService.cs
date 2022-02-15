using BscScan.NetCore.Models.Request.Account;
using BscScan.NetCore.Models.Response.Account;

namespace BscScan.NetCore.Contracts
{
    public interface IBscScanAccountService
    {
        /// <summary>
        /// Get BNB Balance for a Single Address
        /// </summary>
        /// <param name="request">BnbBalanceRequest Model</param>
        /// <returns>Returns the BNB balance of a given address.</returns>
        Task<BnbBalance?> GetBnbBalanceAsync(BnbBalanceRequest request);

        /// <summary>
        /// Get BNB Balance for Multiple Addresses in a Single Call
        /// </summary>
        /// <param name="request">MultipleBnbBalanceRequest Model</param>
        /// <returns>Returns the balance of the accounts from a list of addresses.</returns>
        Task<BnbMultipleBalances?> GetMultipleBnbBalanceAsync(MultipleBnbBalanceRequest request);

        /// <summary>
        /// Get a list of 'Normal' Transactions By Address
        /// </summary>
        /// <param name="request">NormalTransactionRequest Model</param>
        /// <returns>Returns the list of transactions performed by an address, with optional pagination.</returns>
        /// <remarks>This API endpoint returns a maximum of 10000 records only.</remarks>
        Task<NormalTransactions?> GetNormalTransactionsByAddressAsync(NormalTransactionRequest request);


        /// <summary>
        /// Get a list of 'Internal' Transactions by Address
        /// </summary>
        /// <param name="request">InternalTransactionRequest Model</param>
        /// <returns>Returns the list of internal transactions performed by an address, with optional pagination.</returns>
        Task<InternalTransactionsByAddress?> GetInternalTransactionsByAddressAsync(InternalTransactionRequest request);

        /// <summary>
        /// Get 'Internal Transactions' by Transaction Hash
        /// </summary>
        /// <param name="txHash">the string representing the transaction hash to check for internal transactions</param>
        /// <returns>Returns the list of internal transactions performed within a transaction.</returns>
        Task<InternalTransactionsByHash?> GetInternalTransactionsByTransactionHashAsync(string txHash);
    }
}
