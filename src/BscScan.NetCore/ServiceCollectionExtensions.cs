using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Services;

namespace BscScan.NetCore;

/// <summary>
/// BscScanService CollectionExtensions
/// </summary>
public static class BscScanServiceCollectionExtensions
{
    /// <summary>
    ///  BscScanService CollectionExtensions
    /// </summary>
    /// <param name="services">IServiceCollection</param>
    /// <param name="bscScanConfiguration">BscScanConfiguration</param>
    public static void AddBscScan(this IServiceCollection? services, BscScanConfiguration bscScanConfiguration)
    {
        if (services == null) return;

        var configureClient = new Action<HttpClient>(client =>
        {
            client.BaseAddress = new Uri(bscScanConfiguration.BscScanOptions.Uri!);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MimeTypes.ApplicationJson));
        });
        
        services.AddHttpClient<IBscScanAccountsService, BscScanAccountsService>(configureClient);

        services.AddHttpClient<IBscScanContractsService, BscScanContractsService>(configureClient);

        services.AddHttpClient<IBscScanTransactionService, BscScanTransactionService>(configureClient);

        services.AddHttpClient<IBscScanBlocksService, BscScanBlocksService>(configureClient);

        services.AddHttpClient<IBscScanGethProxyService, BscScanGethProxyService>(configureClient);
    }
}