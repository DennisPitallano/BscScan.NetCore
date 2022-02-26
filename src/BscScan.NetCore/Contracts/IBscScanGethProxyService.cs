﻿using BscScan.NetCore.Models.Response.Proxy;

namespace BscScan.NetCore.Contracts
{
    /// <summary>
    /// Geth Proxy Module
    /// </summary>
    public interface IBscScanGethProxyService
    {
        /// <summary>
        /// eth_blockNumber
        /// </summary>
        /// <returns>
        /// Returns the number of most recent block
        /// </returns>
        Task<EthBlockNumber?> EthBlockNumber();

        /// <summary>
        /// eth_getBlockByNumber
        /// </summary>
        /// <param name="tag">the block number, in hex eg. 0xC36B3C</param>
        /// when true, returns full transaction objects and their information, when false only returns a list of transactions.</param>
        /// <returns>Returns information about a block by block number.</returns>
        Task<BlockByNumber?> EthGetBlockByNumber(string tag);

        /// <summary>
        /// eth_getBlockTransactionCountByNumber
        /// </summary>
        /// <param name="tag">the block number, in hex eg. 0x10FB78</param>
        /// <returns>Returns the number of transactions in a block</returns>
        Task<BlockTransactionCountByNumber?> EthGetBlockTransactionCountByNumber(string tag);

        /// <summary>
        /// eth_getBlockTransactionCountByNumber
        /// </summary>
        /// <param name="txhash">the string representing the hash of the transaction</param>
        /// <returns>Returns the number of transactions in a block.</returns>
        Task<TransactionByHash?> EthGetTransactionByHash(string txhash);
    }
}
