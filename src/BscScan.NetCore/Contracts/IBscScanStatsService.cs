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
}