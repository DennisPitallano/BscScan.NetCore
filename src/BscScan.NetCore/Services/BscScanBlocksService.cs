using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Models;
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
        public async Task<BlockRewards?> GetBlockRewardsByBlockNo(string blockNo)
        {
            var queryParameters = $"{_bscScanModule}".AddAction(BlocksModuleAction.GET_BLOCK_REWARD)
                .AddQuery(BscQueryParam.BlockNo.AppendValue(blockNo));
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<BlockRewards>(responseStream);
            return result;
        }


        /// <inheritdoc />
        public async Task<EstimatedBlockCountdownTime?> GetEstimatedBlockCountdownTimeByBlockNo(string blockNo)
        {
            var queryParameters = $"{_bscScanModule}".AddAction(BlocksModuleAction.GET_BLOCK_COUNT_DOWN)
                .AddQuery(BscQueryParam.BlockNo.AppendValue(blockNo));
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<EstimatedBlockCountdownTime>(responseStream);
            return result;
        }

        /// <inheritdoc />
        public async Task<BlockNumber?> GetBlockNumberByTimestamp(int timestamp, Closest closest = Closest.Before)
        {
            var queryParameters = $"{_bscScanModule}".AddAction(BlocksModuleAction.GET_BLOCK_NUMBER_BY_TIMESTAMP)
                .AddQuery(BscQueryParam.Timestamp.AppendValue(timestamp)).AddQuery(BscQueryParam.Closest.AppendValue(closest.ToString().ToLower()));
            using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var result = await JsonSerializer.DeserializeAsync<BlockNumber>(responseStream);
            return result;
        }
    }
}
