namespace BscScan.NetCore.Services;

/// <inheritdoc cref="IBscScanTransactionService" />
public class BscScanTransactionService : BaseHttpClient, IBscScanTransactionService
{
    private readonly string _bscScanModule;

    /// <inheritdoc />
    public BscScanTransactionService(HttpClient bscScanHttpClient, BscScanConfiguration bscScanConfiguration) : base(
        bscScanHttpClient, bscScanConfiguration)
    {
        _bscScanModule = BscScanModule.TRANSACTIONS.AppendApiKey(bscScanConfiguration.BscScanOptions.Token);
    }

    /// <inheritdoc />
    public async Task<TransactionReceiptStatus?> CheckTransactionReceiptStatusAsync(string txHash)
    {
        var queryParameters = $"{_bscScanModule}".AddAction(TransactionsModuleAction.GET_TX_RECEIPT_STATUS)
            .AddQuery(BscQueryParam.TxHash.AppendValue(txHash));
        using var response = await BscScanHttpClient.GetAsync($"{queryParameters}")
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
        await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        var result = await JsonSerializer.DeserializeAsync<TransactionReceiptStatus>(responseStream);
        return result;
    }
}