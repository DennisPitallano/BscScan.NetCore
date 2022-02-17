namespace BscScan.NetCore.Constants;

internal static class BscModule
{
    public const string ACCOUNT = "?module=account&apikey={apiKey}&";
    public const string CONTRACT = "?module=contract&apikey={apiKey}&";
    public const string TRANSACTIONS = "?module=transaction&apikey={apiKey}&";
}

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


internal static class ContractsModuleAction
{
    public const string GET_ABI = "getabi";
}

internal static class BscQueryParam
{
    public const string TxHash = "txhash={value}";
    public const string Address = "address={value}";
    public const string BlockNo = "blockno={value}";
    public const string BlockType = "blocktype={value}";
}