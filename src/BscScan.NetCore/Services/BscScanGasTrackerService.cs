using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Models.Response.GasTracker;

namespace BscScan.NetCore.Services;

/// <inheritdoc cref="IBscScanGasTrackerService" />
public class BscScanGasTrackerService : BaseHttpClient, IBscScanGasTrackerService
{

    private readonly string _bscScanGasTrackerModule;
    /// <inheritdoc />
    public BscScanGasTrackerService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration)
        : base(bscScanHttpClient, bscScanConfiguration)
    {
        _bscScanGasTrackerModule = BscScanModule.GAS_TRACKER.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
    }

    /// <inheritdoc />
    public async Task<GasOracle?> GetGasOracle()
    {
        var queryParameters = $"{_bscScanGasTrackerModule}".AddAction(GasTrackerModuleAction.GAS_ORACLE);
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<GasOracle>(responseStream);
        return result;
    }
}