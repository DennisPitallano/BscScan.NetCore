using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Models;
using BscScan.NetCore.Models.Request.Blocks;
using BscScan.NetCore.Models.Response.Blocks;

namespace BscScan.NetCore.Services;

/// <inheritdoc cref="IBscScanBlocksService" />
public class BscScanBlocksService :BaseHttpClient, IBscScanBlocksService
{
    private readonly string _bscScanModuleBlock;
    private readonly string _bscScanModuleStat;

    /// <inheritdoc />
    public BscScanBlocksService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration) : base(bscScanHttpClient, bscScanConfiguration)
    {
        _bscScanModuleStat = BscScanModule.STATS.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
        _bscScanModuleBlock = BscScanModule.BLOCKS.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
    }

    /// <inheritdoc />
    public async Task<BlockRewards?> GetBlockRewardsByBlockNo(string blockNo)
    {
        var queryParameters = $"{_bscScanModuleBlock}".AddAction(BlocksModuleAction.GET_BLOCK_REWARD)
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
        var queryParameters = $"{_bscScanModuleBlock}".AddAction(BlocksModuleAction.GET_BLOCK_COUNT_DOWN)
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
        var queryParameters = $"{_bscScanModuleBlock}".AddAction(BlocksModuleAction.GET_BLOCK_NUMBER_BY_TIMESTAMP)
            .AddQuery(BscQueryParam.Timestamp.AppendValue(timestamp)).AddQuery(BscQueryParam.Closest.AppendValue(closest.ToString().ToLower()));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BlockNumber>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<DailyAverageBlockSize?> GetDailyAverageBlockSize(DailyAverageBlockSizeRequest request)
    {
        var queryParameters = $"{_bscScanModuleStat}{request.ToRequestParameters(BlocksModuleAction.GET_DAILY_AVG_BLOCK_SIZE)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<DailyAverageBlockSize>(responseStream);
        return result;
    }


    /// <inheritdoc />
    public async Task<DailyBlockCountAndRewards?> GetDailyBlockCountsAndRewards(DailyBlockCountAndRewardRequest request)
    {
        var queryParameters = $"{_bscScanModuleStat}{request.ToRequestParameters(BlocksModuleAction.GET_DAILY_BLOCK_COUNT)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<DailyBlockCountAndRewards>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<DailyBlockRewards?> GetDailyBlockRewards(DailyBlockRequest request)
    {
        var queryParameters = $"{_bscScanModuleStat}{request.ToRequestParameters(BlocksModuleAction.GET_DAILY_BLOCK_REWARDS)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<DailyBlockRewards>(responseStream);
        return result;
    }

    /// <inheritdoc />
    public async Task<DailyAverageTimeForBlock?> GetDailyAverageTimeForABlock(DailyBlockRequest request)
    {
        var queryParameters = $"{_bscScanModuleStat}{request.ToRequestParameters(BlocksModuleAction.GET_DAILY_AVG_BLOCK_TIME)}";
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<DailyAverageTimeForBlock>(responseStream);
        return result;
    }
}