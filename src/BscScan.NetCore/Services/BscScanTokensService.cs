using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Models;
using BscScan.NetCore.Models.Request.Tokens;
using BscScan.NetCore.Models.Response.Tokens;

namespace BscScan.NetCore.Services
{
    /// <inheritdoc cref="IBscScanTokensService" />
    public class BscScanTokensService : BaseHttpClient, IBscScanTokensService
    {
        private readonly string _bscScanModuleToken;
        private readonly string _bscScanModuleStat;
        private readonly string _bscScanModuleAccount;

        /// <inheritdoc />
        public BscScanTokensService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration)
            : base(bscScanHttpClient, bscScanConfiguration)
        {
            _bscScanModuleStat = BscScanModule.STATS.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
            _bscScanModuleToken = BscScanModule.TOKEN.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
            _bscScanModuleAccount = BscScanModule.ACCOUNT.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
        }

        /// <inheritdoc />
        public async Task<TokenTotalSupply?> GetBep20TokenTotalSupplyByContractAddress(string contractAddress)
        {
            var queryParameters = $"{_bscScanModuleStat}".AddAction(TokenModuleAction.TOKEN_SUPPLY)
                .AddQuery(BscQueryParam.ContractAddress.AppendValue(contractAddress));
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<TokenTotalSupply>(responseStream);
            return result;
        }

        /// <inheritdoc />
        public async Task<TokenCirculatingSupply?> GetBep20TokenCirculatingSupplyByContractAddress(string contractAddress)
        {
            var queryParameters = $"{_bscScanModuleStat}".AddAction(TokenModuleAction.TOKEN_C_SUPPLY)
                .AddQuery(BscQueryParam.ContractAddress.AppendValue(contractAddress));
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<TokenCirculatingSupply>(responseStream);
            return result;
        }

        /// <inheritdoc />
        public async Task<TokenAccountBalance?> GetBep20TokenAccountBalanceByContractAddress(string contractAddress, string address)
        {
            var queryParameters = $"{_bscScanModuleAccount}".AddAction(TokenModuleAction.TOKEN_BALANCE)
                .AddQuery(BscQueryParam.ContractAddress.AppendValue(contractAddress))
                .AddQuery(BscQueryParam.Address.AppendValue(address))
                .AddQuery(BscQueryParam.Tag.AppendValue(Tag.Latest.ToString().ToLower()));

            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<TokenAccountBalance>(responseStream);
            return result;
        }

        /// <inheritdoc />
        public async Task<TokenHolderList?> GetTokenHolderListByContractAddress(TokenHolderListRequest request)
        {
            var queryParameters = $"{_bscScanModuleToken}{request.ToRequestParameters(TokenModuleAction.TOKEN_HOLDER_LIST)}";
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<TokenHolderList>(responseStream);
            return result;
        }

        /// <inheritdoc />
        public async Task<HistoricalBep20TokenTotalSupply?> GetHistoricalBep20TokenTotalSupplyByContractAddressAndBlockNo(
            string contractAddress, int blockNo)
        {
            var queryParameters = $"{_bscScanModuleStat}".AddAction(TokenModuleAction.TOKEN_SUPPLY_HISTORY)
                .AddQuery(BscQueryParam.ContractAddress.AppendValue(contractAddress))
                .AddQuery(BscQueryParam.BlockNo.AppendValue(blockNo))
                .AddQuery(BscQueryParam.Tag.AppendValue(Tag.Latest.ToString().ToLower()));

            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<HistoricalBep20TokenTotalSupply>(responseStream);
            return result;
        }

        /// <inheritdoc />
        public async Task<HistoricalBep20TokenAccountBalance?> GetHistoricalBep20TokenAccountBalanceByContractAddressAndBlockNo(
            HistoricalBep20TokenAccountBalanceRequest request)
        {
            var queryParameters = $"{_bscScanModuleAccount}{request.ToRequestParameters(TokenModuleAction.TOKEN_BALANCE_HISTORY)}";
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<HistoricalBep20TokenAccountBalance>(responseStream);
            return result;
        }

        /// <inheritdoc />
        public async Task<TokenInfo?> GetTokenInfoByContractAddress(string contractAddress)
        {
            var queryParameters = $"{_bscScanModuleToken}".AddAction(TokenModuleAction.TOKEN_INFO)
                .AddQuery(BscQueryParam.ContractAddress.AppendValue(contractAddress));
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<TokenInfo>(responseStream);
            return result;
        }

        /// <inheritdoc />
        public async Task<AddressBep20TokenHolding?> GetAddressBep20TokenHolding(AddressBep20TokenHoldingRequest request)
        {
            var queryParameters = $"{_bscScanModuleAccount}{request.ToRequestParameters(TokenModuleAction.ADDRESS_TOKEN_BALANCE)}";
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<AddressBep20TokenHolding>(responseStream);
            return result;
        }

        /// <inheritdoc />
        public async Task<AddressBep721TokenHolding?> GetAddressBep721TokenHolding(AddressBep721TokenHoldingRequest request)
        {
            var queryParameters = $"{_bscScanModuleAccount}{request.ToRequestParameters(TokenModuleAction.ADDRESS_TOKEN_NFT_BALANCE)}";
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<AddressBep721TokenHolding>(responseStream);
            return result;
        }
    }
}
