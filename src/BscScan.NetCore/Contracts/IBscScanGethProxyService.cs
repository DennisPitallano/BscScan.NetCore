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
    }
}
