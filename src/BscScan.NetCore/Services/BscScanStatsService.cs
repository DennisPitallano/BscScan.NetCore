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
    public async Task<TotalSupply?> GetTotalSupplyAsync()
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
    public async Task<ValidatorsList?> GetValidatorsListAsync()
    {
        var queryParameters = $"{_bscScanStatsModule}".AddAction(GasStatsModuleAction.VALIDATOR_LIST);
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<ValidatorsList>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<BnbLastPrice?> GetBnbLastPriceAsync()
    {
        var queryParameters = $"{_bscScanStatsModule}".AddAction(GasStatsModuleAction.BNB_PRICE);
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BnbLastPrice>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<BnbHistoricalPrice?> GetBnbHistoricalPriceAsync(BnbHistoricalPriceRequest request)
    {
        var queryParameters =
            $"{_bscScanStatsModule}{request.ToRequestParameters(GasStatsModuleAction.BNB_DAILY_PRICE)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BnbHistoricalPrice>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<DailyNetworkTransactionFee?> GetDailyNetworkTransactionFeeAsync(
        DailyNetworkTransactionFeeRequest request)
    {
        var queryParameters = $"{_bscScanStatsModule}{request.ToRequestParameters(GasStatsModuleAction.DAILY_TXN_FEE)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<DailyNetworkTransactionFee>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<DailyNewAddressCount?> GetDailyNewAddressCountAsync(DailyNewAddressCountRequest request)
    {
        var queryParameters =
            $"{_bscScanStatsModule}{request.ToRequestParameters(GasStatsModuleAction.DAILY_NEW_ADDRESS)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<DailyNewAddressCount>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<DailyNetworkUtilization?> GetDailyNetworkUtilizationAsync(DailyNetworkUtilizationRequest request)
    {
        var queryParameters =
            $"{_bscScanStatsModule}{request.ToRequestParameters(GasStatsModuleAction.DAILY_NET_UTILIZATION)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<DailyNetworkUtilization>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<DailyTransactionCount?> GetDailyTransactionCountAsync(DailyTransactionCountRequest request)
    {
        var queryParameters = $"{_bscScanStatsModule}{request.ToRequestParameters(GasStatsModuleAction.DAILY_TX)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<DailyTransactionCount>(responseStream);
        return result;
    }
}