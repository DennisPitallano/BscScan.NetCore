using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Models;
using BscScan.NetCore.Models.Request.Proxy;
using BscScan.NetCore.Models.Response.Proxy;

namespace BscScan.NetCore.Services;

/// <inheritdoc cref="IBscScanGethProxyService"/>
public class BscScanGethProxyService: BaseHttpClient, IBscScanGethProxyService
{
    private readonly string _bscScanModule;
    /// <inheritdoc />
    public BscScanGethProxyService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration) : base(bscScanHttpClient, bscScanConfiguration)
    {
        _bscScanModule = BscScanModule.PROXY.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
    }

    /// <inheritdoc />
    public async Task<EthBlockNumber?> EthBlockNumberAsync()
    {
        var queryParameters = $"{_bscScanModule}".AddAction(ProxyModuleAction.ETH_BLOCK_NUMBER);
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<EthBlockNumber>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<BlockByNumber?> EthGetBlockByNumberAsync(string tag)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(ProxyModuleAction.ETH_GET_BLOCk_BY_NUMBER)
            .AddQuery(BscQueryParam.Tag.AppendValue(tag)).AddQuery(BscQueryParam.Boolean.AppendValue("true"));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BlockByNumber>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<BlockTransactionCountByNumber?> EthGetBlockTransactionCountByNumberAsync(string tag)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(ProxyModuleAction.ETH_GET_BLOCk_TRANSACTION_COUNT_BY_NUMBER)
            .AddQuery(BscQueryParam.Tag.AppendValue(tag));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BlockTransactionCountByNumber>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<TransactionByHash?> EthGetTransactionByHashAsync(string txhash)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(ProxyModuleAction.ETH_GET_TRANSACTION_BY_HASH)
            .AddQuery(BscQueryParam.TxHash.AppendValue(txhash));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<TransactionByHash>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<TransactionByBlockNumberAndIndex?> EthGetTransactionByBlockNumberAndIndexAsync(string tag, string index)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(ProxyModuleAction.ETH_GET_TRANSACTION_BY_BLOCK_NUMBER_AND_INDEX)
            .AddQuery(BscQueryParam.Tag.AppendValue(tag)).AddQuery(BscQueryParam.Index.AppendValue(index));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<TransactionByBlockNumberAndIndex>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<TransactionCount?> EthGetTransactionCountAsync(string address, Tag tag = Tag.Latest)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(ProxyModuleAction.ETH_GET_TRANSACTION_COUNT)
            .AddQuery(BscQueryParam.Tag.AppendValue(tag.ToString().ToLower())).AddQuery(BscQueryParam.Address.AppendValue(address));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<TransactionCount>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<SendRawTransaction?> EthSendRawTransactionAsync(string hex)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(ProxyModuleAction.ETH_SEND_RAW_TRANSACTION)
            .AddQuery(BscQueryParam.Hex.AppendValue(hex));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<SendRawTransaction>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<TransactionReceipt?> EthGetTransactionReceiptAsync(string txhash)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(ProxyModuleAction.ETH_GET_TRANSACTION_RECEIPT)
            .AddQuery(BscQueryParam.TxHash.AppendValue(txhash));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<TransactionReceipt>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<EthCall?> EthCallAsync(string to, string data, Tag tag = Tag.Latest)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(ProxyModuleAction.ETH_CALL)
            .AddQuery(BscQueryParam.Tag.AppendValue(tag.ToString().ToLower()))
            .AddQuery(BscQueryParam.Data.AppendValue(data))
            .AddQuery(BscQueryParam.To.AppendValue(to));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<EthCall>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<EthCode?> EthGetCodeAsync(string address, Tag tag = Tag.Latest)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(ProxyModuleAction.ETH_GET_CODE)
            .AddQuery(BscQueryParam.Tag.AppendValue(tag.ToString().ToLower()))
            .AddQuery(BscQueryParam.Address.AppendValue(address));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<EthCode>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<EthStorageAt?> EthGetStorageAtAsync(string address, string position, Tag tag = Tag.Latest)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(ProxyModuleAction.ETH_GET_STORAGE_AT)
            .AddQuery(BscQueryParam.Tag.AppendValue(tag.ToString().ToLower()))
            .AddQuery(BscQueryParam.Position.AppendValue(position))
            .AddQuery(BscQueryParam.Address.AppendValue(address));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<EthStorageAt>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<EthGasPrice?> EthGasPriceAsync()
    {
        var queryParameters = $"{_bscScanModule}".AddAction(ProxyModuleAction.ETH_GAS_PRICE);
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<EthGasPrice>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<EthEstimateGas?> EthEstimateGasAsync(EthEstimateGasRequest request)
    {
        var queryParameters = $"{_bscScanModule}{request.ToRequestParameters(ProxyModuleAction.ETH_ESTIMATE_GAS)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<EthEstimateGas>(responseStream);
        return result;
    }
}