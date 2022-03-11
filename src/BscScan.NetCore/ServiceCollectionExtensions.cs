using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
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
    /// <param name="configuration"></param>
    public static void AddBscScan(this IServiceCollection? services, IConfiguration configuration)
    {
        if (services == null) return;

        var bscScanConfiguration = new BscScanConfiguration();
        configuration.GetSection(nameof(BscScanOptions)).Bind(bscScanConfiguration);
        services.AddSingleton(bscScanConfiguration);

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

        services.AddHttpClient<IBscScanTokensService, BscScanTokensService>(configureClient);

        services.AddHttpClient<IBscScanGasTrackerService, BscScanGasTrackerService>(configureClient);

        services.AddHttpClient<IBscScanStatsService, BscScanStatsService>(configureClient);
    }
}