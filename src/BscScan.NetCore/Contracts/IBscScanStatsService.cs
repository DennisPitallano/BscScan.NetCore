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
    Task<TotalSupply> GetTotalSupply();
}