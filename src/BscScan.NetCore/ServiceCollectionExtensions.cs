using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Services;

namespace BscScan.NetCore;

public static class BscScanServiceCollectionExtensions
{
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
    }
}