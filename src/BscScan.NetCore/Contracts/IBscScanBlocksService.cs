using BscScan.NetCore.Models;
using BscScan.NetCore.Models.Request.Blocks;
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

       
        /// <summary>
        /// Get Block Number by Timestamp
        /// </summary>
        /// <param name="timestamp">the integer representing the Unix timestamp in seconds.</param>
        /// <param name="closest">the closest available block to the provided timestamp, either before or after</param>
        /// <returns>Returns the block number that was validated at a certain timestamp.</returns>
        Task<BlockNumber?> GetBlockNumberByTimestamp(int timestamp, Closest closest =Closest.Before );

        /// <summary>
        /// Get Daily Average Block Size  🅰🅿🅸  🅿🆁🅾
        /// </summary>
        /// <param name="request">DailyAverageBlockSizeRequest Model</param>
        /// <returns>Returns the daily average block size within a date range.</returns>
        Task<DailyAverageBlockSize?> GetDailyAverageBlockSize(DailyAverageBlockSizeRequest request);
        

        /// <summary>
        /// Get Daily Block Count and Rewards  🅰🅿🅸  🅿🆁🅾
        /// </summary>
        /// <param name="request">DailyBlockCountAndRewardRequest Model</param>
        /// <returns>Returns the number of blocks validated daily and the amount of block rewards.</returns>
        Task<DailyBlockCountAndRewards?> GetDailyBlockCountsAndRewards(DailyBlockCountAndRewardRequest request);

        /// <summary>
        /// Get Daily Block Rewards  🅰🅿🅸  🅿🆁🅾
        /// </summary>
        /// <param name="request">DailyBlockRequest Model</param>
        /// <returns>Returns the amount of block rewards distributed to validators daily.</returns>
        Task<DailyBlockRewards?> GetDailyBlockRewards(DailyBlockRequest request);

        /// <summary>
        /// Get Daily Average Time for A Block to be Included in the BNB Smart Chain   🅰🅿🅸  🅿🆁🅾
        /// </summary>
        /// <param name="request">DailyBlockRequest Model</param>
        /// <returns>Returns the daily average of time needed for a block to be successfully validated.</returns>
        Task<DailyAverageTimeForBlock?> GetDailyAverageTimeForABlock(DailyBlockRequest request);
    }
}
