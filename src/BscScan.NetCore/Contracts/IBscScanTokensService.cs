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
    }
}
