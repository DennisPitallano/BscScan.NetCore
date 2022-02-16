﻿using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Models.Request.Account;
using BscScan.NetCore.Models.Response.Account;

namespace BscScan.NetCore.Services;

public class BscScanAccountsService : BaseHttpClient, IBscScanAccountsService
{
    private readonly string _bscScanModule;
    public BscScanAccountsService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration) :
        base(bscScanHttpClient, bscScanConfiguration)
    {
        _bscScanModule = BscModule.ACCOUNT.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
    }

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

    public async Task<InternalTransactionsByAddress?> GetInternalTransactionsByAddressAsync(InternalTransactionsRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountsModuleAction.TRANSACTION_LIST_INTERNAL)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<InternalTransactionsByAddress>(responseStream);
        return result;
    }

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

    public async Task<InternalTransactionsByBlockRange?> GetInternalTransactionsByBlockRangeAsync(InternalTransactionsByBlockRangeRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountsModuleAction.TRANSACTION_LIST_INTERNAL)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<InternalTransactionsByBlockRange>(responseStream);
        return result;
    }

    public async Task<Bep20TokenTransferEvents?> GetBep20TokenTransferEventsByAddress(Bep20TokenTransferEventsRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountsModuleAction.TOKEN_TX)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<Bep20TokenTransferEvents>(responseStream);
        return result;
    }

    public async Task<Bep721TokenTransferEvents?> GetBep721TokenTransferEventsByAddress(Bep721TokenTransferEventsRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountsModuleAction.TOKEN_NFT_TX)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<Bep721TokenTransferEvents>(responseStream);
        return result;
    }

    public async Task<BlocksValidated?> GetBlocksValidatedByAddress(BlocksValidatedRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(AccountsModuleAction.GET_MINED_BLOCKS)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BlocksValidated>(responseStream);
        return result;
    }

    public async Task<BnbBalanceHistoryByBlockNo?> GetHistoricalBnbBalanceByBlockNo(string address, int blockno)
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