using BscScan.NetCore.Models.Response.Blocks;

namespace BscScan.NetCore.Contracts
{
    /// <summary>
    /// BscScan Blocks Module API Interface
    /// </summary>
    public interface IBscScanBlocksService
    {
        /// <summary>
        /// Get Block Rewards by BlockNo
        /// </summary>
        /// <param name="blockNo">the integer block number to check block rewards for eg. 12697906</param>
        /// <returns>Returns the block reward awarded for validating a certain block.</returns>
        Task<BlockRewards?> GetBlockRewardsByBlockNo(string blockNo);
    }
}
