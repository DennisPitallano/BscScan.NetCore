using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Models.Response.Contracts;

namespace BscScan.NetCore.Services
{
    public class BscScanContractsService : BaseHttpClient, IBscScanContractsService
    {
        private readonly string _bscScanModule;
        public BscScanContractsService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration) : base(bscScanHttpClient, bscScanConfiguration)
        {
            _bscScanModule = BscScanModule.CONTRACT.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
        }

        public async Task<ContractApplicationBinaryInterface?> GetContractApplicationBinaryInterface(string address)
        {
            var queryParameters = $"{_bscScanModule}".AddAction(ContractsModuleAction.GET_ABI)
                .AddQuery(BscQueryParam.Address.AppendValue(address));
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<ContractApplicationBinaryInterface>(responseStream);
            return result;
        }

        public async Task<ContractSourceCode?> GetContractSourceCode(string address)
        {
            var queryParameters = $"{_bscScanModule}".AddAction(ContractsModuleAction.GET_SOURCE_CODE)
                .AddQuery(BscQueryParam.Address.AppendValue(address));
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<ContractSourceCode>(responseStream);
            return result;
        }
    }
}
