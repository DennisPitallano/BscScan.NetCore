namespace BscScan.NetCore.Constants;

/// <summary>
/// BscScan Modules
/// </summary>
internal static class BscScanModule
{
    public const string ACCOUNT = "?module=account&apikey={apiKey}&";
    public const string CONTRACT = "?module=contract&apikey={apiKey}&";
    public const string TRANSACTIONS = "?module=transaction&apikey={apiKey}&";
    public const string BLOCKS = "?module=block&apikey={apiKey}&";
    public const string STATS = "?module=stats&apikey={apiKey}&";
}

/// <summary>
/// BscScan Accounts Module Actions
/// </summary>
internal static class AccountsModuleAction
{
    public const string BALANCE = "balance";
    public const string BALANCE_HISTORY = "balancehistory";
    public const string BALANCE_MULTI = "balancemulti";
    public const string TRANSACTION_LIST = "txlist";
    public const string TRANSACTION_LIST_INTERNAL = "txlistinternal";
    public const string TOKEN_TX = "tokentx";
    public const string TOKEN_NFT_TX = "tokennfttx";
    public const string GET_MINED_BLOCKS = "getminedblocks";
}

/// <summary>
/// BscScan Contracts Module Actions
/// </summary>
internal static class ContractsModuleAction
{
    public const string GET_ABI = "getabi";
    public const string GET_SOURCE_CODE = "getsourcecode";
    public const string GET_BLOCK_NO_BY_TIME = "getblocknobytime";
}

/// <summary>
/// BscScan Contracts Module Actions
/// </summary>
internal static class TransactionsModuleAction
{
    public const string GET_TX_RECEIPT_STATUS = "gettxreceiptstatus";
}

/// <summary>
/// BscScan Blocks Module Actions
/// </summary>
internal static class BlocksModuleAction
{
    public const string GET_BLOCK_REWARD = "getblockreward";
    public const string GET_BLOCK_COUNT_DOWN= "getblockcountdown";
    public const string GET_BLOCK_NUMBER_BY_TIMESTAMP= "getblocknobytime";
    public const string GET_DAILY_AVG_BLOCK_SIZE = "dailyavgblocksize";
    public const string GET_DAILY_BLOCK_COUNT = "dailyblkcount";
    public const string GET_DAILY_BLOCK_REWARDS = "dailyblockrewards";
    public const string GET_DAILY_AVG_BLOCK_TIME = "dailyavgblocktime";
}


/// <summary>
/// BscScan shared Query Params
/// </summary>
internal static class BscQueryParam
{
    public const string TxHash = "txhash={value}";
    public const string Address = "address={value}";
    public const string BlockNo = "blockno={value}";
    public const string BlockType = "blocktype={value}";
    public const string Timestamp = "timestamp={value}";
    public const string Closest = "closest={value}";
}

internal static class MimeTypes
{
    public const string ApplicationJson = "application/json";
}