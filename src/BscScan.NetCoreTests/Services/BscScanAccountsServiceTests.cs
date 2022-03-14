using System;
using System.Text.Json;
using System.Threading.Tasks;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Models.Request.Accounts;
using BscScan.NetCoreTests;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BscScan.NetCore.Services.Tests
{
    [TestClass()]
    public class BscScanAccountsServiceTests : TestBase
    {
        private const string Message = "OK";

        [TestMethod()]
        public void BscScanAccountsServiceTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public async Task GetBnbBalanceAsyncTest()
        {
            var bscScanAccountsService = _serviceProvider.GetRequiredService<IBscScanAccountsService>();
            var test = await bscScanAccountsService.GetBnbBalanceAsync(new BnbBalanceRequest
            {
                Address = "0x70F657164e5b75689b64B7fd1fA275F334f28e18"
            });
            Console.WriteLine(JsonSerializer.Serialize(test));
            Assert.AreEqual(test?.Message, Message);
        }

        [TestMethod()]
        public void GetMultipleBnbBalanceAsyncTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetNormalTransactionsByAddressAsyncTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetInternalTransactionsByAddressAsyncTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetInternalTransactionsByTransactionHashAsyncTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetInternalTransactionsByBlockRangeAsyncTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetBep20TokenTransferEventsByAddressAsyncTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetBep721TokenTransferEventsByAddressAsyncTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetBlocksValidatedByAddressAsyncTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetHistoricalBnbBalanceByBlockNoAsyncTest()
        {
            Assert.Fail();
        }
    }
}