using BscScan.NetCore.Models;
using BscScan.NetCore.Models.Request.Proxy;
using BscScan.NetCore.Models.Response.Proxy;

namespace BscScan.NetCore.Contracts;

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
    Task<EthBlockNumber?> EthBlockNumberAsync();

    /// <summary>
    /// eth_getBlockByNumber
    /// </summary>
    /// <param name="tag">the block number, in hex eg. 0xC36B3C</param>
    /// when true, returns full transaction objects and their information, when false only returns a list of transactions.
    /// <returns>Returns information about a block by block number.</returns>
    Task<BlockByNumber?> EthGetBlockByNumberAsync(string tag);

    /// <summary>
    /// eth_getBlockTransactionCountByNumber
    /// </summary>
    /// <param name="tag">the block number, in hex eg. 0x10FB78</param>
    /// <returns>Returns the number of transactions in a block</returns>
    Task<BlockTransactionCountByNumber?> EthGetBlockTransactionCountByNumberAsync(string tag);

    /// <summary>
    /// eth_getBlockTransactionCountByNumber
    /// </summary>
    /// <param name="txhash">the string representing the hash of the transaction</param>
    /// <returns>Returns the number of transactions in a block.</returns>
    Task<TransactionByHash?> EthGetTransactionByHashAsync(string txhash);

    /// <summary>
    /// eth_getTransactionByBlockNumberAndIndex
    /// </summary>
    /// <param name="tag">he block number, in hex eg. 0x10FB78</param>
    /// <param name="index">the position of the uncle's index in the block, in hex eg. 0x1</param>
    /// <returns></returns>
    Task<TransactionByBlockNumberAndIndex?> EthGetTransactionByBlockNumberAndIndexAsync(string tag, string index);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="address">the string representing the address to get transaction count</param>
    /// <param name="tag">the string pre-defined block parameter, either earliest, pending or latest</param>
    /// <returns>Returns the number of transactions performed by an address.</returns>
    Task<TransactionCount?> EthGetTransactionCountAsync(string address, Tag tag = Tag.Latest);

    /// <summary>
    /// eth_sendRawTransaction
    /// </summary>
    /// <param name="hex">the string representing the signed raw transaction data to broadcast.</param>
    /// <returns>Submits a pre-signed transaction for broadcast to the BNB Smart Chain network.</returns>
    Task<SendRawTransaction?> EthSendRawTransactionAsync(string hex);

    /// <summary>
    /// eth_getTransactionReceipt
    /// </summary>
    /// <param name="txhash">the string representing the hash of the transaction</param>
    /// <returns>Returns the receipt of a transaction that has been validated.</returns>
    Task<TransactionReceipt?> EthGetTransactionReceiptAsync(string txhash);

    /// <summary>
    /// eth_call
    /// </summary>
    /// <param name="to">the string representing the address to interact with</param>
    /// <param name="data">the hash of the method signature and encoded parameters</param>
    /// <param name="tag">the string pre-defined block parameter, either earliest, pending or latest</param>
    /// <returns>Executes a new message call immediately without creating a transaction on the block chain.</returns>
    Task<EthCall?> EthCallAsync(string to, string data, Tag tag = Tag.Latest);

    /// <summary>
    /// eth_getCode
    /// </summary>
    /// <param name="address">the string representing the address to get code</param>
    /// <param name="tag">the string pre-defined block parameter, either earliest, pending or latest</param>
    /// <returns>Returns code at a given address.</returns>
    Task<EthCode?> EthGetCodeAsync(string address, Tag tag = Tag.Latest);

    /// <summary>
    /// eth_getStorageAt
    /// Note: This endpoint is still experimental and may have potential issues
    /// </summary>
    /// <param name="address">the string representing the address to get code</param>
    /// <param name="position">the hex code of the position in storage, eg 0x0</param>
    /// <param name="tag">the string pre-defined block parameter, either earliest, pending or latest</param>
    /// <returns>Returns the value from a storage position at a given address.</returns>
    Task<EthStorageAt?> EthGetStorageAtAsync(string address,string position, Tag tag = Tag.Latest);

    /// <summary>
    /// eth_gasPrice
    /// </summary>
    /// <returns>Returns the current price per gas in wei.</returns>
    Task<EthGasPrice?> EthGasPriceAsync();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request">EthEstimateGasRequest Model</param>
    /// <returns></returns>
    Task<EthEstimateGas?> EthEstimateGasAsync(EthEstimateGasRequest request);
}