using BscScan.NetCore.Models.Response;

namespace BscScan.NetCore.Contracts
{
    public interface IBscScanAccountService
    {
        /// <summary>
        /// Get BNB Balance for a Single Address
        /// </summary>
        /// <param name="address">the string representing the address to check for balance</param>
        /// <returns>Returns the BNB balance of a given address.</returns>
        Task<BnbBalance?> GetBalanceAsync(string address);

        Task<BnbMultipleBalance?> GetMultipleBalanceAsync(string[] addresses);
    }
}
