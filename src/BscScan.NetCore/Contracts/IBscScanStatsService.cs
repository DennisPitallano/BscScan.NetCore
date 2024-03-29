﻿namespace BscScan.NetCore.Contracts;

/// <summary>
///  BscScan Stats Module Interface
/// </summary>
public interface IBscScanStatsService
{
    /// <summary>
    /// Get Total Supply of BNB on the BNB Smart Chain
    /// </summary>
    /// <returns>Returns the current amount of BNB in circulation.</returns>
    Task<TotalSupply?> GetTotalSupplyAsync();

    /// <summary>
    /// Get Validators List on the BNB Smart Chain
    /// </summary>
    /// <returns>Returns the top 21 validators for the BNB Smart Chain.</returns>
    Task<ValidatorsList?> GetValidatorsListAsync();

    /// <summary>
    /// Get BNB Last Price
    /// </summary>
    /// <returns>Returns the latest price of 1 BNB.</returns>
    Task<BnbLastPrice?> GetBnbLastPriceAsync();

    /// <summary>
    /// Get BNB Historical Price 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">BnbHistoricalPriceRequest</param>
    /// <returns>Returns the historical price of 1 BNB.</returns>
    Task<BnbHistoricalPrice?> GetBnbHistoricalPriceAsync(BnbHistoricalPriceRequest request);

    /// <summary>
    /// Get Daily Network Transaction Fee 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">DailyNetworkTransactionFeeRequest</param>
    /// <returns>Returns the historical amount of transaction fees paid to validators per day.</returns>
    Task<DailyNetworkTransactionFee?> GetDailyNetworkTransactionFeeAsync(DailyNetworkTransactionFeeRequest request);

    /// <summary>
    /// Get Daily New Address Count 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">DailyNewAddressCountRequest</param>
    /// <returns>Returns the historical number of new BNB Smart Chain addresses created per day.</returns>
    Task<DailyNewAddressCount?> GetDailyNewAddressCountAsync(DailyNewAddressCountRequest request);

    /// <summary>
    /// Get Daily Network Utilization 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">DailyNetworkUtilizationRequest</param>
    /// <returns>Returns the daily average gas used over gas limit percentage.</returns>
    Task<DailyNetworkUtilization?> GetDailyNetworkUtilizationAsync(DailyNetworkUtilizationRequest request);

    /// <summary>
    /// Get Daily Transaction Count 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">DailyTransactionCountRequest</param>
    /// <returns>Returns the number of transactions performed on the Ethereum blockchain per day.</returns>
    Task<DailyTransactionCount?> GetDailyTransactionCountAsync(DailyTransactionCountRequest request);
}