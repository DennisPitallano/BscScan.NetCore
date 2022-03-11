# <img align="right" src="https://raw.githubusercontent.com/DennisPitallano/BscScan.NetCore/main/src/BscScan.NetCore/BscScan.NetCore.png" >BscScan.🅽🅴🆃🅲🅾🆁🅴

A BscScan API  Wrapper for .Net Core.

`BscScan.NetCore` includes both **community endpoints** and  [**API PRO**](https://docs.bscscan.com/api-pro/etherscan-api-pro) 

For your API Key, please follow [BscScan Getting Started Guide](https://docs.bscscan.com/getting-started/creating-an-account)

[![bscscan.netcore on fuget.org](https://www.fuget.org/packages/bscscan.netcore/badge.svg)](https://www.fuget.org/packages/bscscan.netcore) [![Nuget](https://img.shields.io/nuget/v/BscScan.NetCore?logo=nuget)](https://www.nuget.org/packages/BscScan.NetCore) ![Nuget](https://img.shields.io/nuget/dt/BscScan.NetCore)

# # 🐲BSC API ENDPOINTS:

**Current Version** `version 1.0.5`

### 🎯**BscScan Accounts API**

- [x] [Get BNB Balance for a Single Address](https://docs.bscscan.com/api-endpoints/accounts#get-bnb-balance-for-a-single-address)
- [x] [Get BNB Balance for Multiple Addresses in a Single Call](https://docs.bscscan.com/api-endpoints/accounts#get-bnb-balance-for-multiple-addresses-in-a-single-call)
- [x] [Get Historical BNB Balance for a Single Address by BlockNo `🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/accounts#get-historical-bnb-balance-for-a-single-address-by-blockno)
- [x] [Get a list of 'Normal' Transactions By Address](https://docs.bscscan.com/api-endpoints/accounts#get-a-list-of-normal-transactions-by-address)
- [x] [Get a list of 'Internal' Transactions by Address](https://docs.bscscan.com/api-endpoints/accounts#get-a-list-of-internal-transactions-by-address)
- [x] [Get 'Internal Transactions' by Transaction Hash](https://docs.bscscan.com/api-endpoints/accounts#get-internal-transactions-by-transaction-hash)
- [x] [Get "Internal Transactions" by Block Range](https://docs.bscscan.com/api-endpoints/accounts#get-internal-transactions-by-block-range)
- [x] [Get a list of 'BEP-20 Token Transfer Events' by Address](https://docs.bscscan.com/api-endpoints/accounts#get-a-list-of-bep-20-token-transfer-events-by-address)
- [x] [Get a list of 'BEP-721 Token Transfer Events' by Address](https://docs.bscscan.com/api-endpoints/accounts#get-a-list-of-bep-721-token-transfer-events-by-address)
- [x] [Get list of Blocks Validated by Address](https://docs.bscscan.com/api-endpoints/accounts#get-list-of-blocks-validated-by-address)

### 🎯**BscScan Contracts Api**

- [x] [Get Contract ABI for Verified Contract Source Codes](https://docs.bscscan.com/api-endpoints/contracts#get-contract-abi-for-verified-contract-source-codes)
- [x] [Get Contract Source Code for Verified Contract Source Codes](https://docs.bscscan.com/api-endpoints/contracts#get-contract-source-code-for-verified-contract-source-codes)
- [ ] Verify Source Code
  - [ ] Source Code Submission Gist
  - [ ] Check Source Code Verification Submission Status
- [ ] Verify Proxy Contract
  - [ ] Verifying Proxy Contract
  - [ ] Checking Proxy Contract Verification Submission Status

### 🎯BscScan Transactions Api

- [x] [Check Transaction Receipt Status](https://docs.bscscan.com/api-endpoints/stats#check-transaction-receipt-status)

### 🎯BscScan Blocks Api

- [x] [Get Block Rewards by BlockNo](https://docs.bscscan.com/api-endpoints/blocks#get-block-rewards-by-blockno)
- [x] [Get Estimated Block Countdown Time by BlockNo](https://docs.bscscan.com/api-endpoints/blocks#get-estimated-block-countdown-time-by-blockno)
- [x] [Get Block Number by Timestamp](https://docs.bscscan.com/api-endpoints/blocks#get-block-number-by-timestamp)
- [x] [Get Daily Average Block Size `🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/blocks#get-daily-average-block-size)
- [x] [Get Daily Block Count and Rewards `🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/blocks#get-daily-block-count-and-rewards)
- [x] [Get Daily Block Rewards `🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/blocks#get-daily-block-rewards)
- [x] [Get Daily Average Time for A Block to be Included in the BNB Smart Chain `🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/blocks#get-daily-average-time-for-a-block-to-be-included-in-the-bnb-smart-chain)

### 🎯BscScan Logs Api

- [ ] fromBlock, toBlock, address
- [ ] topic0, topic1, topic2, topic3 (32 Bytes per topic)
- [ ] topic0_1_opr (and|or between topic0 & topic1), topic1_2_opr (and|or between topic1 & topic2), topic2_3_opr (and|or between topic2 & topic3), topic0_2_opr (and|or between topic0 & topic2), topic0_3_opr (and|or between topic0 & topic3), topic1_3_opr (and|or between topic1 & topic3)

### 🎯BscScan Geth Proxy Api

- [x] [eth_blockNumber](https://docs.bscscan.com/api-endpoints/geth-parity-proxy#eth_blocknumber)
- [x] [eth_getBlockByNumber](https://docs.bscscan.com/api-endpoints/geth-parity-proxy#eth_getblockbynumber)
- [x] [eth_getBlockTransactionCountByNumber](https://docs.bscscan.com/api-endpoints/geth-parity-proxy#eth_getblocktransactioncountbynumber)
- [x] [eth_getTransactionByHash](https://docs.bscscan.com/api-endpoints/geth-parity-proxy#eth_gettransactionbyhash)
- [x] [eth_getTransactionByBlockNumberAndIndex](https://docs.bscscan.com/api-endpoints/geth-parity-proxy#eth_gettransactionbyblocknumberandindex)
- [x] [eth_getTransactionCount](https://docs.bscscan.com/api-endpoints/geth-parity-proxy#eth_gettransactioncount)
- [x] [eth_sendRawTransaction](https://docs.bscscan.com/api-endpoints/geth-parity-proxy#eth_sendrawtransaction)
- [x] [eth_getTransactionReceipt](https://docs.bscscan.com/api-endpoints/geth-parity-proxy#eth_gettransactionreceipt)
- [x] [eth_call](https://docs.bscscan.com/api-endpoints/geth-parity-proxy#eth_call)
- [x] [eth_getCode](https://docs.bscscan.com/api-endpoints/geth-parity-proxy#eth_getcode)
- [x] [eth_getStorageAt](https://docs.bscscan.com/api-endpoints/geth-parity-proxy#eth_getstorageat)
- [x] [eth_gasPrice](https://docs.bscscan.com/api-endpoints/geth-parity-proxy#eth_gasprice)
- [x] [eth_estimateGas](https://docs.bscscan.com/api-endpoints/geth-parity-proxy#eth_estimategas)

### 🎯BscScan Tokens Api

- [x] [Get BEP-20 Token TotalSupply by ContractAddress](https://docs.bscscan.com/api-endpoints/tokens#get-bep-20-token-totalsupply-by-contractaddress)
- [x] [Get BEP-20 Token CirculatingSupply by ContractAddress](https://docs.bscscan.com/api-endpoints/tokens#get-bep-20-token-circulatingsupply-by-contractaddress)
- [x] [Get BEP-20 Token Account Balance by ContractAddress](https://docs.bscscan.com/api-endpoints/tokens#get-bep-20-token-account-balance-by-contractaddress)
- [x] [Get Token Holder List by Contract Address `🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/tokens#get-token-holder-list-by-contract-address)
- [x] [Get Historical BEP-20 Token TotalSupply by ContractAddress & BlockNo `🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/tokens#get-historical-bep-20-token-totalsupply-by-contractaddress-and-blockno)
- [x] [Get Historical BEP-20 Token Account Balance by ContractAddress & BlockNo `🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/tokens#get-historical-bep-20-token-account-balance-by-contractaddress-and-blockno)
- [x] [Get Token Info by ContractAddress `🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/tokens#get-token-info-by-contractaddress)
- [x] [Get Address BEP20 Token Holding `🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/tokens#get-address-bep20-token-holding)
- [x] [Get Address BEP721 Token Holding `🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/tokens#get-address-bep721-token-holding)
- [x] [Get Address BEP721 Token Inventory By Contract Address `🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/tokens#get-address-bep721-token-inventory-by-contract-address)

### 🎯BscScan Gas Tracker Api

- [x] [Get Gas Oracle](https://docs.bscscan.com/api-endpoints/gas-tracker#get-gas-oracle)
- [x] [Get Daily Average Gas Limit`🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/gas-tracker#get-daily-average-gas-limit)
- [x] [Get BNB Smart Chain Daily Total Gas Used`🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/gas-tracker#get-bnb-smart-chain-daily-total-gas-used)
- [x] [Get Daily Average Gas Price`🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/gas-tracker#get-daily-average-gas-price)

### 🎯BscScan Stats Api

- [x] [Get Total Supply of BNB on the BNB Smart Chain](https://docs.bscscan.com/api-endpoints/stats-1#get-total-supply-of-bnb-on-the-bnb-smart-chain)
- [x] [Get Validators List on the BNB Smart Chain](https://docs.bscscan.com/api-endpoints/stats-1#get-validators-list-on-the-bnb-smart-chain)
- [x] [Get BNB Last Price](https://docs.bscscan.com/api-endpoints/stats-1#get-bnb-last-price)
- [x] [Get BNB Historical Price`🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/stats-1#get-bnb-historical-price)
- [x] [Get Daily Network Transaction Fee`🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/stats-1#get-daily-network-transaction-fee)
- [x] [Get Daily New Address Count`🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/stats-1#get-daily-new-address-count)
- [x] [Get Daily Network Utilization`🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/stats-1#get-daily-network-utilization)
- [x] [Get Daily Transaction Count`🅿🆁🅾`](https://docs.bscscan.com/api-endpoints/stats-1#get-daily-transaction-count)

# Installation

1. Download and Install the latest `BscScan.NetCore` from [NuGet](https://www.nuget.org/packages/BscScan.NetCore/) using Package Manager, CLI or by adding it to Package Reference:
   
   ```shell
   <PackageReference Include="BscScan.NetCore" Version="1.0.5" />
   ```
   
   ```shell
   dotnet add package BscScan.NetCore --version 1.0.5
   ```
   
   ```shell
   PM> Install-Package BscScan.NetCore -Version 1.0.5
   ```

2. Import the following namespace in the class:
   
   ```c#
   using BscScan.NetCore;
   ```

## See the detailed guide [here](https://dennispitallano.github.io/docs/bscsan-netcore/get-start).
