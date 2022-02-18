using BscScan.NetCore.Configuration;

namespace BscScan.NetCore.Services;

/// <summary>
/// Base Http Client
/// </summary>
public class BaseHttpClient
{
    /// <summary>
    /// HttpClient
    /// </summary>
    protected readonly HttpClient BscScanHttpClient;
    
    /// <summary>
    /// BscScanConfiguration 
    /// </summary>
    protected readonly BscScanConfiguration BscScanConfiguration;
    /// <summary>
    ///  Base Http Client Constructor
    /// </summary>
    /// <param name="bscScanHttpClient">HttpClient</param>
    /// <param name="bscScanConfiguration">BscScanConfiguration </param>
    public BaseHttpClient(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration)
    {
        BscScanHttpClient = bscScanHttpClient;
        BscScanConfiguration = bscScanConfiguration;
    }
}