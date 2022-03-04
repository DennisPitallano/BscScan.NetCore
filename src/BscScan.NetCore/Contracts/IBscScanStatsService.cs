using BscScan.NetCore.Models.Request.Stats;
using BscScan.NetCore.Models.Response.Stats;

namespace BscScan.NetCore.Contracts;

/// <summary>
///  BscScan Stats Module Interface
/// </summary>
public interface IBscScanStatsService
{
    /// <summary>
    /// Get Total Supply of BNB on the BNB Smart Chain
    /// </summary>
    /// <returns>Returns the current amount of BNB in circulation.</returns>
    Task<TotalSupply?> GetTotalSupply();

    /// <summary>
    /// Get Validators List on the BNB Smart Chain
    /// </summary>
    /// <returns>Returns the top 21 validators for the BNB Smart Chain.</returns>
    Task<ValidatorsList?> GetValidatorsList();

    /// <summary>
    /// Get BNB Last Price
    /// </summary>
    /// <returns>Returns the latest price of 1 BNB.</returns>
    Task<BnbLastPrice?> GetBnbLastPrice();

    /// <summary>
    /// Get BNB Historical Price 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">BnbHistoricalPriceRequest</param>
    /// <returns>Returns the historical price of 1 BNB.</returns>
    Task<BnbHistoricalPrice?> GetBnbHistoricalPrice(BnbHistoricalPriceRequest request);

    /// <summary>
    /// Get Daily Network Transaction Fee 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">DailyNetworkTransactionFeeRequest</param>
    /// <returns>Returns the historical amount of transaction fees paid to validators per day.</returns>
    Task<DailyNetworkTransactionFee?> GetDailyNetworkTransactionFee(DailyNetworkTransactionFeeRequest request);

    /// <summary>
    /// Get Daily New Address Count 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">DailyNewAddressCountRequest</param>
    /// <returns>Returns the historical number of new BNB Smart Chain addresses created per day.</returns>
    Task<DailyNewAddressCount?> GetDailyNewAddressCount(DailyNewAddressCountRequest request);

    /// <summary>
    /// Get Daily Network Utilization 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">DailyNetworkUtilizationRequest</param>
    /// <returns>Returns the daily average gas used over gas limit percentage.</returns>
    Task<DailyNetworkUtilization?> GetDailyNetworkUtilization(DailyNetworkUtilizationRequest request);
}