namespace BscScan.NetCore.Configuration;

/// <summary>
/// BscScan Configuration Interface
/// </summary>
public interface IBscScanConfiguration
{
    /// <summary>
    /// BscScan Options
    /// </summary>
    BscScanOptions BscScanOptions { get; }
}