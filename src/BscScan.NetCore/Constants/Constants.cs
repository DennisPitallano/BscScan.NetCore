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
    public const string PROXY = "?module=proxy&apikey={apiKey}&";
    public const string TOKEN = "?module=token&apikey={apiKey}&";
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


internal static class ProxyModuleAction
{
    public const string ETH_BLOCK_NUMBER = "eth_blockNumber";
    public const string ETH_GET_BLOCk_BY_NUMBER = "eth_getBlockByNumber";
    public const string ETH_GET_BLOCk_TRANSACTION_COUNT_BY_NUMBER = "eth_getBlockTransactionCountByNumber";
    public const string ETH_GET_TRANSACTION_BY_HASH = "eth_getTransactionByHash";
    public const string ETH_GET_TRANSACTION_BY_BLOCK_NUMBER_AND_INDEX = "eth_getTransactionByBlockNumberAndIndex";
    public const string ETH_GET_TRANSACTION_COUNT = "eth_getTransactionCount";
    public const string ETH_SEND_RAW_TRANSACTION = "eth_sendRawTransaction";
    public const string ETH_GET_TRANSACTION_RECEIPT = "eth_getTransactionReceipt";
    public const string ETH_CALL = "eth_call";
    public const string ETH_GET_CODE = "eth_getCode";
    public const string ETH_GET_STORAGE_AT = "eth_getStorageAt";
    public const string ETH_GAS_PRICE = "eth_gasPrice";
    public const string ETH_ESTIMATE_GAS = "eth_estimateGas";
}

internal static class TokenModuleAction
{
    public const string TOKEN_SUPPLY = "tokensupply";
    public const string TOKEN_C_SUPPLY = "tokenCsupply";
    public const string TOKEN_BALANCE = "tokenbalance";
    public const string TOKEN_HOLDER_LIST = "tokenholderlist";
    public const string TOKEN_SUPPLY_HISTORY = "tokensupplyhistory";
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
    public const string Tag = "tag={value}";
    public const string Boolean = "boolean={value}";
    public const string Index = "index={value}";
    public const string Hex = "hex={value}";
    public const string To = "to={value}";
    public const string Data = "data={value}";
    public const string Position = "position={value}";
    public const string ContractAddress = "contractaddress={value}";
}

internal static class MimeTypes
{
    public const string ApplicationJson = "application/json";
}