namespace BscScan.NetCore.Services;

/// <inheritdoc cref="IBscScanGasTrackerService" />
public class BscScanGasTrackerService : BaseHttpClient, IBscScanGasTrackerService
{
    private readonly string _bscScanGasTrackerModule;
    private readonly string _bscScanStatsModule;

    /// <inheritdoc />
    public BscScanGasTrackerService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration) : base(
        bscScanHttpClient, bscScanConfiguration)
    {
        _bscScanGasTrackerModule = BscScanModule.GAS_TRACKER.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
        _bscScanStatsModule = BscScanModule.STATS.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
    }

    /// <inheritdoc />
    public async Task<GasOracle?> GetGasOracleAsync()
    {
        var queryParameters = $"{_bscScanGasTrackerModule}".AddAction(GasTrackerModuleAction.GAS_ORACLE);
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<GasOracle>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<DailyAverageGasLimit?> GetDailyAverageGasLimitAsync(DailyAverageGasLimitRequest request)
    {
        var queryParameters =
            $"{_bscScanStatsModule}{request.ToRequestParameters(GasTrackerModuleAction.DAILY_AVG_GAS_LIMIT)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<DailyAverageGasLimit>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<BnbSmartChainDailyTotalGasUsed?> GetBnbSmartChainDailyTotalGasUsedAsync(
        BnbSmartChainDailyTotalGasUsedRequest request)
    {
        var queryParameters =
            $"{_bscScanStatsModule}{request.ToRequestParameters(GasTrackerModuleAction.DAILY_GAS_USED)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BnbSmartChainDailyTotalGasUsed>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<DailyAverageGasPrice?> GetDailyAverageGasPriceAsync(DailyAverageGasPriceRequest request)
    {
        var queryParameters =
            $"{_bscScanStatsModule}{request.ToRequestParameters(GasTrackerModuleAction.DAILY_AVG_GAS_PRICE)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<DailyAverageGasPrice>(responseStream);
        return result;
    }
}