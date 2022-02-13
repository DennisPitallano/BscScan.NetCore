namespace BscScan.NetCore.Models
{
    internal static class DefaultAccountApiEndPoint
    {
        /// <summary>
        /// Get BNB Balance for a Single Address
        /// </summary>
        public const string GET_BALANCE_FOR_SINGLE_ADDRESS =
            "/api?module=account&action=balance&address={address}&apikey={apiKey}";

        public const string GET_BALANCE_FOR_MULTIPLE_ADDRESSES =
            "/api?module=account&action=balancemulti&address={address}&tag=latest&apikey={apiKey}";
    }
}
