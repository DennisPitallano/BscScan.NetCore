using System.Text.Json;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Models;
using BscScan.NetCore.Models.Response;

namespace BscScan.NetCore.Services;

public class BscScanAccountService : BaseHttpClient, IBscScanAccountService
{
    public BscScanAccountService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration) : 
        base(bscScanHttpClient, bscScanConfiguration)
    {
    }
    public async Task<BnbBalance?> GetBalanceAsync(string address)
    {
        //build the parameters from default template
        var requestParameters = DefaultAccountApiEndPoint.GET_BALANCE_FOR_SINGLE_ADDRESS.AddAddress(address)
            .ToRequestParameters(BscScanConfiguration.BscScanOptions.Token);

        using var response = await BscScanHttpClient.GetAsync($"{requestParameters}")
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BnbBalance>(responseStream);
        return result;
    }

    public async Task<BnbMultipleBalance?> GetMultipleBalanceAsync(string[] addresses)
    {
        //build the parameters from default template
        var multiAddress = string.Join(",", addresses);
        var requestParameters = DefaultAccountApiEndPoint.GET_BALANCE_FOR_MULTIPLE_ADDRESSES.AddAddress(multiAddress)
            .ToRequestParameters(BscScanConfiguration.BscScanOptions.Token);

        using var response = await BscScanHttpClient.GetAsync($"{requestParameters}")
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<BnbMultipleBalance>(responseStream);
        return result;
    }
}