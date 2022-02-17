using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BscScan.NetCore.Models.Response.Contracts;

namespace BscScan.NetCore.Contracts
{
    public interface IBscScanContractsService
    {
        Task<ContractApplicationBinaryInterface?> GetContractApplicationBinaryInterface(string address);
    }
}
