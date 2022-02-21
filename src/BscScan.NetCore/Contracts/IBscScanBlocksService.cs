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

        /// <summary>
        /// Get Estimated Block Countdown Time by BlockNo
        /// </summary>
        /// <param name="blockNo">the integer block number to estimate time remaining to be validated eg. 12697906</param>
        /// <returns>Returns the estimated time remaining, in seconds, until a certain block is validated.</returns>
        Task<EstimatedBlockCountdownTime?> GetEstimatedBlockCountdownTimeByBlockNo(string blockNo);
    }
}
