using BscScan.NetCore.Configuration;

namespace BscScan.NetCore.Services;

public class BaseHttpClient
{
    protected readonly HttpClient BscScanHttpClient;
    protected readonly BscScanConfiguration BscScanConfiguration;
    public BaseHttpClient(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration)
    {
        BscScanHttpClient = bscScanHttpClient;
        BscScanConfiguration = bscScanConfiguration;
    }
}