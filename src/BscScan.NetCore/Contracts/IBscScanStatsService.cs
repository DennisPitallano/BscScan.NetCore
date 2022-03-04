﻿using BscScan.NetCore.Models.Request.Stats;
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
}