using BscScan.NetCore.Models.Response.Contracts;

namespace BscScan.NetCore.Services;

/// <inheritdoc cref="IBscScanContractsService" />
public class BscScanContractsService : BaseHttpClient, IBscScanContractsService
{
    private readonly string _bscScanModule;

    /// <inheritdoc />
    public BscScanContractsService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration) : base(
        bscScanHttpClient, bscScanConfiguration)
    {
        _bscScanModule = BscScanModule.CONTRACT.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
    }

    /// <inheritdoc />
    public async Task<ContractApplicationBinaryInterface?> GetContractApplicationBinaryInterfaceAsync(string address)
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

    /// <inheritdoc />
    public async Task<ContractSourceCode?> GetContractSourceCodeAsync(string address)
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