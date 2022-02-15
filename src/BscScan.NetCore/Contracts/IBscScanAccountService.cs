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
        Task<NormalTransactions?> GetNormalTransactionsByAddressAsync(NormalTransactionsRequest request);


        /// <summary>
        /// Get a list of 'Internal' Transactions by Address
        /// </summary>
        /// <param name="request">InternalTransactionRequest Model</param>
        /// <returns>Returns the list of internal transactions performed by an address, with optional pagination.</returns>
        Task<InternalTransactionsByAddress?> GetInternalTransactionsByAddressAsync(InternalTransactionsRequest request);

        /// <summary>
        /// Get 'Internal Transactions' by Transaction Hash
        /// </summary>
        /// <param name="txHash">the string representing the transaction hash to check for internal transactions</param>
        /// <returns>Returns the list of internal transactions performed within a transaction.</returns>
        Task<InternalTransactionsByHash?> GetInternalTransactionsByTransactionHashAsync(string txHash);

        /// <summary>
        /// Get "Internal Transactions" by Block Range
        /// </summary>
        /// <param name="request">InternalTransactionsByBlockRangeRequest Model</param>
        /// <returns>Returns the list of internal transactions performed within a block range, with optional pagination.</returns>
        /// <remarks>This API endpoint returns a maximum of 10000 records only.</remarks>
        Task<InternalTransactionsByBlockRange?> GetInternalTransactionsByBlockRangeAsync(InternalTransactionsByBlockRangeRequest request);

        /// <summary>
        /// Get a list of 'BEP-20 Token Transfer Events' by Address
        /// </summary>
        /// <param name="request">Bep20TokenTransferEventsRequest Model</param>
        /// <remarks> Usage:
        ///    BEP-20 transfers from an address, specify the address parameter.
        ///    BEP-20 transfers from a contract address, specify the contract address parameter.
        ///    BEP-20 transfers from an address filtered by a token contract, specify both address and contract address parameters.
        /// </remarks>
        /// <returns>Returns the list of BEP-20 tokens transferred by an address, with optional filtering by token contract.</returns>
        Task<Bep20TokenTransferEvents?> GetBep20TokenTransferEventsByAddress(Bep20TokenTransferEventsRequest request);

        /// <summary>
        /// Get a list of 'BEP-721 Token Transfer Events' by Address
        /// </summary>
        /// <param name="request"></param>
        /// <remarks>
        /// Usage:
        ///     BEP-721 transfers from an address, specify the address parameter
        ///     BEP-721 transfers from a contract address, specify the contract address parameter
        ///     BEP-721 transfers from an address filtered by a token contract, specify both address and contract address parameters.
        /// </remarks>
        /// <returns>Returns the list of BEP-721 ( NFT ) tokens transferred by an address, with optional filtering by token contract.</returns>
        Task<Bep721TokenTransferEvents?> GetBep721TokenTransferEventsByAddress(Bep721TokenTransferEventsRequest request);
    }
}
