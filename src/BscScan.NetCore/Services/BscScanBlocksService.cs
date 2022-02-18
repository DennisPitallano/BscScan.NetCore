using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Models.Response.Blocks;

namespace BscScan.NetCore.Services
{
    /// <inheritdoc cref="IBscScanBlocksService" />
    public class BscScanBlocksService :BaseHttpClient, IBscScanBlocksService
    {
        private readonly string _bscScanModule;

        /// <inheritdoc />
        public BscScanBlocksService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration) : base(bscScanHttpClient, bscScanConfiguration)
        {
            _bscScanModule = BscScanModule.BLOCKS.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
        }

        /// <inheritdoc />
        public async Task<BlockRewardData?> GetBlockRewardsByBlockNo(string blockNo)
        {
            var queryParameters = $"{_bscScanModule}".AddAction(BlocksModuleAction.GET_BLOCK_REWARD)
                .AddQuery(BscQueryParam.BlockNo.AppendValue(blockNo));
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<BlockRewardData>(responseStream);
            return result;
        }
    }
}
