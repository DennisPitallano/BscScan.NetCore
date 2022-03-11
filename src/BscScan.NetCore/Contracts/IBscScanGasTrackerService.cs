namespace BscScan.NetCore.Contracts;

/// <summary>
/// BscScan Gas Tracker Module Interface
/// </summary>
public interface IBscScanGasTrackerService
{
    /// <summary>
    /// Get Gas Oracle
    /// </summary>
    /// <returns>Returns the current Safe, Proposed and Fast gas prices.</returns>
    Task<GasOracle?> GetGasOracleAsync();

    /// <summary>
    /// Get Daily Average Gas Limit 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">DailyAverageGasLimitRequest</param>
    /// <returns>Returns the historical daily average gas limit of the BNB Smart Chain network.</returns>
    Task<DailyAverageGasLimit?> GetDailyAverageGasLimitAsync(DailyAverageGasLimitRequest request);

    /// <summary>
    /// Get BNB Smart Chain Daily Total Gas Used 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">BnbSmartChainDailyTotalGasUsed</param>
    /// <returns>Returns the total amount of gas used daily for transactions on the BNB Smart Chain network.</returns>
    Task<BnbSmartChainDailyTotalGasUsed?> GetBnbSmartChainDailyTotalGasUsedAsync(BnbSmartChainDailyTotalGasUsedRequest request);

    /// <summary>
    /// Get Daily Average Gas Price 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">DailyAverageGasPriceRequest</param>
    /// <returns>Returns the daily average gas price used on the BNB Smart Chain network.</returns>
    Task<DailyAverageGasPrice?> GetDailyAverageGasPriceAsync(DailyAverageGasPriceRequest request);
}