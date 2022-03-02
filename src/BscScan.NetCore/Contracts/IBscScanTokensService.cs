using BscScan.NetCore.Models.Response.Tokens;

namespace BscScan.NetCore.Contracts
{
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
        Task<TokenTotalSupply?> GetBep20TokenTotalSupplyByContractAddress(string contractAddress);

        /// <summary>
        /// Get BEP-20 Token CirculatingSupply by ContractAddress
        /// </summary>
        /// <param name="contractAddress">the contract address of the BEP-20 token</param>
        /// <returns>Returns the current circulating supply of a BEP-20 token. </returns>
        Task<TokenCirculatingSupply?> GetBep20TokenCirculatingSupplyByContractAddress(string contractAddress);

        /// <summary>
        /// Get BEP-20 Token Account Balance by ContractAddress
        /// </summary>
        /// <param name="contractAddress">the contract address of the BEP-20 token</param>
        /// <param name="address">the string representing the address to check for token balance</param>
        /// <returns>Returns the current balance of a BEP-20 token of an address.</returns>
        Task<TokenAccountBalance?> GetBep20TokenAccountBalanceByContractAddress(string contractAddress, string address);
    }
}
