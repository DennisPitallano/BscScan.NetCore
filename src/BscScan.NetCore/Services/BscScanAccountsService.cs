namespace BscScan.NetCore.Services;

/// <inheritdoc cref="IBscScanAccountsService" />
public class BscScanAccountsService : BaseHttpClient, IBscScanAccountsService
{
    private readonly string _bscScanModule;

    /// <inheritdoc />
    public BscScanAccountsService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration) :
        base(bscScanHttpClient, bscScanConfiguration)
    {
        _bscScanModule = BscScanModule.ACCOUNT.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
    }

    /// <inheritdoc />
    public async Task<BnbBalance?> GetBnbBalanceAsync(BnbBalanceRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountsModuleAction.BALANCE)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BnbBalance>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<BnbMultipleBalances?> GetMultipleBnbBalanceAsync(MultipleBnbBalanceRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountsModuleAction.BALANCE_MULTI)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BnbMultipleBalances>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<NormalTransactions?> GetNormalTransactionsByAddressAsync(NormalTransactionsRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountsModuleAction.TRANSACTION_LIST)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<NormalTransactions>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<InternalTransactionsByAddress?> GetInternalTransactionsByAddressAsync(
        InternalTransactionsRequest request)
    {
        var queryParameters =
            $"{_bscScanModule}{request.ToRequestParameters(AccountsModuleAction.TRANSACTION_LIST_INTERNAL)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<InternalTransactionsByAddress>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<InternalTransactionsByHash?> GetInternalTransactionsByTransactionHashAsync(string txHash)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(AccountsModuleAction.TRANSACTION_LIST_INTERNAL)
            .AddQuery(BscQueryParam.TxHash.AppendValue(txHash));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<InternalTransactionsByHash>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<InternalTransactionsByBlockRange?> GetInternalTransactionsByBlockRangeAsync(
        InternalTransactionsByBlockRangeRequest request)
    {
        var queryParameters =
            $"{_bscScanModule}{request.ToRequestParameters(AccountsModuleAction.TRANSACTION_LIST_INTERNAL)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<InternalTransactionsByBlockRange>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<Bep20TokenTransferEvents?> GetBep20TokenTransferEventsByAddressAsync(
        Bep20TokenTransferEventsRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountsModuleAction.TOKEN_TX)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<Bep20TokenTransferEvents>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<Bep721TokenTransferEvents?> GetBep721TokenTransferEventsByAddressAsync(
        Bep721TokenTransferEventsRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountsModuleAction.TOKEN_NFT_TX)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<Bep721TokenTransferEvents>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<BlocksValidated?> GetBlocksValidatedByAddressAsync(BlocksValidatedRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountsModuleAction.GET_MINED_BLOCKS)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BlocksValidated>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<BnbBalanceHistoryByBlockNo?> GetHistoricalBnbBalanceByBlockNoAsync(string address, int blockno)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(AccountsModuleAction.BALANCE_HISTORY)
            .AddQuery(BscQueryParam.Address.AppendValue(address).AddQuery(BscQueryParam.BlockNo.AppendValue(blockno)));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();

        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BnbBalanceHistoryByBlockNo>(responseStream);
        return result;
    }
}