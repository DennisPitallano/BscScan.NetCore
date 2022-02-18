namespace BscScan.NetCore.Configuration;

/// <inheritdoc />
public class BscScanConfiguration : IBscScanConfiguration
{
    /// <inheritdoc />
    public BscScanOptions BscScanOptions { get; set; } = new BscScanOptions();
}