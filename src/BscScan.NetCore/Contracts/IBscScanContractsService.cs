using BscScan.NetCore.Models.Response.Contracts;

namespace BscScan.NetCore.Contracts
{
    /// <summary>
    /// BscScan Contract Module Interface
    /// </summary>
    public interface IBscScanContractsService
    {

        /// <summary>
        /// Get Contract ABI for Verified Contract Source Codes
        /// </summary>
        /// <param name="address">the contract address that has a verified source code</param>
        /// <returns>Returns the contract Application Binary Interface ( ABI ) of a verified smart contract.</returns>
        Task<ContractApplicationBinaryInterface?> GetContractApplicationBinaryInterface(string address);

        /// <summary>
        /// Get Contract Source Code for Verified Contract Source Codes
        /// </summary>
        /// <param name="address">the contract address that has a verified source code</param>
        /// <returns>Returns the Solidity source code of a verified smart contract.</returns>
        Task<ContractSourceCode?> GetContractSourceCode(string address);
    }
}
