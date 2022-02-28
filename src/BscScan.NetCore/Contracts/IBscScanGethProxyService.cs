using BscScan.NetCore.Models;
using BscScan.NetCore.Models.Response.Proxy;

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

        /// <summary>
        /// eth_getTransactionByBlockNumberAndIndex
        /// </summary>
        /// <param name="tag">he block number, in hex eg. 0x10FB78</param>
        /// <param name="index">the position of the uncle's index in the block, in hex eg. 0x1</param>
        /// <returns></returns>
        Task<TransactionByBlockNumberAndIndex?> EthGetTransactionByBlockNumberAndIndex(string tag, string index);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address">the string representing the address to get transaction count</param>
        /// <param name="tag">the string pre-defined block parameter, either earliest, pending or latest</param>
        /// <returns>Returns the number of transactions performed by an address.</returns>
        Task<TransactionCount?> EthGetTransactionCount(string address, Tag tag = Tag.Latest);

        /// <summary>
        /// eth_sendRawTransaction
        /// </summary>
        /// <param name="hex">the string representing the signed raw transaction data to broadcast.</param>
        /// <returns>Submits a pre-signed transaction for broadcast to the BNB Smart Chain network.</returns>
        Task<SendRawTransaction?> EthSendRawTransaction(string hex);

        /// <summary>
        /// eth_getTransactionReceipt
        /// </summary>
        /// <param name="txhash">the string representing the hash of the transaction</param>
        /// <returns>Returns the receipt of a transaction that has been validated.</returns>
        Task<TransactionReceipt?> EthGetTransactionReceipt(string txhash);
    }
}
