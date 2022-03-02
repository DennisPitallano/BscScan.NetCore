using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Models.Response.Tokens;

namespace BscScan.NetCore.Services
{
    /// <inheritdoc cref="IBscScanTokensService" />
    public class BscScanTokensService : BaseHttpClient, IBscScanTokensService
    {
        private readonly string _bscScanModuleToken;
        private readonly string _bscScanModuleStat;

        /// <inheritdoc />
        public BscScanTokensService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration) : base(bscScanHttpClient, bscScanConfiguration)
        {
            _bscScanModuleStat = BscScanModule.STATS.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
            _bscScanModuleToken = BscScanModule.TOKEN.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
        }

        /// <inheritdoc />
        public async Task<TokenTotalSupply?> GetBep20TokenTotalSupplyByContractAddress(string contractAddress)
        {
            var queryParameters = $"{_bscScanModuleStat}".AddAction(TokenModuleAction.TOKEN_HOLDER_LIST)
                .AddQuery(BscQueryParam.ContractAddress.AppendValue(contractAddress));
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<TokenTotalSupply>(responseStream);
            return result;
        }
    }
}
