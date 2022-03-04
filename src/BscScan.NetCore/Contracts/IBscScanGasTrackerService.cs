using BscScan.NetCore.Models.Response.GasTracker;

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
    Task<GasOracle?> GetGasOracle();
}