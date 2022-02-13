namespace BscScan.NetCore.Configuration
{
    public class BscScanConfiguration : IBscScanConfiguration
    {
        public BscScanOptions BscScanOptions { get; set; } = new BscScanOptions();
    }
}
