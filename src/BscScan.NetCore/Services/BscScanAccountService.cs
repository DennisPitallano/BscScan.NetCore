using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Models.Request.Account;
using BscScan.NetCore.Models.Response.Account;

namespace BscScan.NetCore.Services;

public class BscScanAccountService : BaseHttpClient, IBscScanAccountService
{
    private readonly string _bscScanModule;
    public BscScanAccountService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration) :
        base(bscScanHttpClient, bscScanConfiguration)
    {
        _bscScanModule = BscModule.ACCOUNT.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
    }

    public async Task<BnbBalance?> GetBnbBalanceAsync(BnbBalanceRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountModuleAction.BALANCE)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BnbBalance>(responseStream);
        return result;
    }

    public async Task<BnbMultipleBalances?> GetMultipleBnbBalanceAsync(MultipleBnbBalanceRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountModuleAction.BALANCE_MULTI)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BnbMultipleBalances>(responseStream);
        return result;
    }

    public async Task<NormalTransactions?> GetNormalTransactionsByAddressAsync(NormalTransactionsRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountModuleAction.TRANSACTION_LIST)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<NormalTransactions>(responseStream);
        return result;
    }

    public async Task<InternalTransactionsByAddress?> GetInternalTransactionsByAddressAsync(InternalTransactionsRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountModuleAction.TRANSACTION_LIST_INTERNAL)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<InternalTransactionsByAddress>(responseStream);
        return result;
    }

    public async Task<InternalTransactionsByHash?> GetInternalTransactionsByTransactionHashAsync(string txHash)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(AccountModuleAction.TRANSACTION_LIST_INTERNAL)
            .AddQuery(BscQueryParam.TxHash.AppendValue(txHash));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<InternalTransactionsByHash>(responseStream);
        return result;
    }

    public async Task<InternalTransactionsByBlockRange?> GetInternalTransactionsByBlockRangeAsync(InternalTransactionsByBlockRangeRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountModuleAction.TRANSACTION_LIST_INTERNAL)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<InternalTransactionsByBlockRange>(responseStream);
        return result;
    }

    public async Task<Bep20TokenTransferEvents?> GetBep20TokenTransferEventsByAddress(Bep20TokenTransferEventsRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountModuleAction.TOKEN_TX)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<Bep20TokenTransferEvents>(responseStream);
        return result;
    }

    public async Task<Bep721TokenTransferEvents?> GetBep721TokenTransferEventsByAddress(Bep721TokenTransferEventsRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountModuleAction.TOKEN_NFT_TX)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<Bep721TokenTransferEvents>(responseStream);
        return result;
    }
}