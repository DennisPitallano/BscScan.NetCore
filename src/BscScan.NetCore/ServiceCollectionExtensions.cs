using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;
using BscScan.NetCore.Configuration;
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
    public static void AddBscScan(this IServiceCollection? services, BscScanConfiguration bscScanConfiguration )
    {
        services?.AddHttpClient<IBscScanAccountsService, BscScanAccountsService>(client =>
        {
            client.BaseAddress = new Uri(bscScanConfiguration.BscScanOptions.Uri!);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        });

        services?.AddHttpClient<IBscScanContractsService, BscScanContractsService>(client =>
        {
            client.BaseAddress = new Uri(bscScanConfiguration.BscScanOptions.Uri!);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        });

        services?.AddHttpClient<IBscScanTransactionService, BscScanTransactionService>(client =>
        {
            client.BaseAddress = new Uri(bscScanConfiguration.BscScanOptions.Uri!);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        });
    }
}