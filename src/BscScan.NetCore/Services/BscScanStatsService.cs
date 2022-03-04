using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Models.Response.Stats;

namespace BscScan.NetCore.Services;

/// <inheritdoc cref="IBscScanStatsService" />
public class BscScanStatsService : BaseHttpClient, IBscScanStatsService
{
    private readonly string _bscScanStatsModule;

    /// <inheritdoc />
    public BscScanStatsService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration) 
        : base(bscScanHttpClient, bscScanConfiguration)
    {
        _bscScanStatsModule = BscScanModule.STATS.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
    }

    /// <inheritdoc />
    public async Task<TotalSupply?> GetTotalSupply()
    {
        var queryParameters = $"{_bscScanStatsModule}".AddAction(GasStatsModuleAction.BNB_SUPPLY);
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<TotalSupply>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<ValidatorsList?> GetValidatorsList()
    {
        var queryParameters = $"{_bscScanStatsModule}".AddAction(GasStatsModuleAction.VALIDATOR_LIST);
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<ValidatorsList>(responseStream);
        return result;
    }
}