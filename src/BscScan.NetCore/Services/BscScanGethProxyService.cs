using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Models;
using BscScan.NetCore.Models.Response.Proxy;

namespace BscScan.NetCore.Services
{
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
        public async Task<EthBlockNumber?> EthBlockNumber()
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
        public async Task<BlockByNumber?> EthGetBlockByNumber(string tag)
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
        public async Task<BlockTransactionCountByNumber?> EthGetBlockTransactionCountByNumber(string tag)
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
        public async Task<TransactionByHash?> EthGetTransactionByHash(string txhash)
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
        public async Task<TransactionByBlockNumberAndIndex?> EthGetTransactionByBlockNumberAndIndex(string tag, string index)
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
        public async Task<TransactionCount?> EthGetTransactionCount(string address, Tag tag)
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
    }
}
