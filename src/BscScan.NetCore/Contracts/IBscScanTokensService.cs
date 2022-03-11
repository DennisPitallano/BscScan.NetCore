namespace BscScan.NetCore.Contracts;

/// <summary>
/// Tokens Module
/// </summary>
public interface IBscScanTokensService
{
    /// <summary>
    /// Get BEP-20 Token TotalSupply by ContractAddress
    /// </summary>
    /// <param name="contractAddress">the contract address of the BEP-20 token</param>
    /// <returns>Returns the total supply of a BEP-20 token.</returns>
    Task<TokenTotalSupply?> GetBep20TokenTotalSupplyByContractAddressAsync(string contractAddress);

    /// <summary>
    /// Get BEP-20 Token CirculatingSupply by ContractAddress
    /// </summary>
    /// <param name="contractAddress">the contract address of the BEP-20 token</param>
    /// <returns>Returns the current circulating supply of a BEP-20 token. </returns>
    Task<TokenCirculatingSupply?> GetBep20TokenCirculatingSupplyByContractAddressAsync(string contractAddress);

    /// <summary>
    /// Get BEP-20 Token Account Balance by ContractAddress
    /// </summary>
    /// <param name="contractAddress">the contract address of the BEP-20 token</param>
    /// <param name="address">the string representing the address to check for token balance</param>
    /// <returns>Returns the current balance of a BEP-20 token of an address.</returns>
    Task<TokenAccountBalance?>
        GetBep20TokenAccountBalanceByContractAddressAsync(string contractAddress, string address);

    /// <summary>
    /// Get Token Holder List by Contract Address  🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">TokenHolderListRequest</param>
    /// <returns></returns>
    Task<TokenHolderList?> GetTokenHolderListByContractAddressAsync(TokenHolderListRequest request);


    /// <summary>
    /// Get Historical BEP-20 Token TotalSupply by ContractAddress and BlockNo  🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="contractAddress">the contract address of the BEP-20 token</param>
    /// <param name="blockNo">the integer block number to check total supply for eg. 4000000</param>
    /// <returns>Returns the historical amount of a BEP-20 token in circulation at a certain block height.</returns>
    Task<HistoricalBep20TokenTotalSupply?> GetHistoricalBep20TokenTotalSupplyByContractAddressAndBlockNoAsync(
        string contractAddress, int blockNo);


    /// <summary>
    /// Get Historical BEP-20 Token Account Balance by ContractAddress and BlockNo 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">HistoricalBep20TokenAccountBalanceRequest</param>
    /// <returns>Returns the balance of a BEP-20 token of an address at a certain block height.</returns>
    Task<HistoricalBep20TokenAccountBalance?> GetHistoricalBep20TokenAccountBalanceByContractAddressAndBlockNoAsync(
        HistoricalBep20TokenAccountBalanceRequest request);

    /// <summary>
    /// Get Token Info by ContractAddress 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="contractAddress">the contract address of the BEP-20/BEP721 token to retrieve token info</param>
    /// <returns>Returns project information and social media links of a BEP-20/BEP-721 token.</returns>
    Task<TokenInfo?> GetTokenInfoByContractAddressAsync(string contractAddress);

    /// <summary>
    /// Get Address BEP20 Token Holding 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">AddressBep20TokenHoldingRequest</param>
    /// <returns>Returns the BEP-20 tokens and amount held by an address.</returns>
    Task<AddressBep20TokenHolding?> GetAddressBep20TokenHoldingAsync(AddressBep20TokenHoldingRequest request);

    /// <summary>
    /// Get Address BEP721 Token Holding 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">AddressBep721TokenHoldingRequest</param>
    /// <returns>Returns the BEP-721 tokens and amount held by an address. </returns>
    Task<AddressBep721TokenHolding?> GetAddressBep721TokenHoldingAsync(AddressBep721TokenHoldingRequest request);


    /// <summary>
    /// Get Address BEP721 Token Inventory By Contract Address 🅰🅿🅸  🅿🆁🅾
    /// </summary>
    /// <param name="request">AddressBep721TokenInventoryRequest</param>
    /// <returns>Returns the BEP-721 token inventory of an address, filtered by contract address.</returns>
    Task<AddressBep721TokenInventory?> GetAddressBep721TokenInventoryByContractAddressAsync(
        AddressBep721TokenInventoryRequest request);
}