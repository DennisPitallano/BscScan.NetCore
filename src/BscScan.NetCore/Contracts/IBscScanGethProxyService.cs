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
        /// <param name="boolean">the boolean value to show full transaction objects.
        /// when true, returns full transaction objects and their information, when false only returns a list of transactions.</param>
        /// <returns>Returns information about a block by block number.</returns>
        Task<BlockByNumber?> EthGetBlockByNumber(string tag);
    }
}
