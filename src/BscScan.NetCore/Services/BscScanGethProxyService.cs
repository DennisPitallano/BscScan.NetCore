using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
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
    }
}
