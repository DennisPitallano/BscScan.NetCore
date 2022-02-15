namespace BscScan.NetCore.Constants
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

        public const string GET_A_LIST_OF_NORMAL_TRANSACTIONS_BY_ADDRESS =
            "/api?module=account&action=txlist&address={address}&startblock={startblock}&endblock={endblock}" +
            "&page={page}&offset={offset}&sort={sortOrder}&apikey={apiKey}";

        public const string BASE_QUERY =
            "/api?apikey={apiKey}";
    }
   
    internal static class BscModule
    {
        public const string ACCOUNT = "/api?module=account&apikey={apiKey}&";
        public const string CONTRACT = "/api?module=contract&apikey={apiKey}&";
        public const string TRANSACTIONS = "/api?module=transaction&apikey={apiKey}&";
    }

    internal static class AccountModuleAction
    {
        public const string BALANCE = "balance";
        public const string BALANCE_MULTI = "balancemulti";
        public const string TRANSACTION_LIST = "txlist";
        public const string TRANSACTION_LIST_INTERNAL = "txlistinternal";
    }
}
