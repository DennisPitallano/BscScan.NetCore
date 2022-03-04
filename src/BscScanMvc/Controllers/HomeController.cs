using BscScanMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Models.Request.GasTracker;

namespace BscScanMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IBscScanAccountsService _bscScanService;

        private readonly IBscScanContractsService _bscScanContractsService;

        private readonly IBscScanTransactionService _bscScanTransactionService;

        private readonly IBscScanBlocksService _bscScanBlocksService;

        private readonly IBscScanGethProxyService _bscScanGethProxyService;
        private readonly IBscScanTokensService _bscScanTokensService;
        private readonly IBscScanGasTrackerService _bscScanGasTrackerService;
        public HomeController(ILogger<HomeController> logger, IBscScanAccountsService bscScanService, IBscScanContractsService bscScanContractsService, IBscScanTransactionService bscScanTransactionService, IBscScanBlocksService bscScanBlocksService, IBscScanGethProxyService bscScanGethProxyService, IBscScanTokensService bscScanTokensService, IBscScanGasTrackerService bscScanGasTrackerService)
        {
            _logger = logger;
            _bscScanService = bscScanService;
            _bscScanContractsService = bscScanContractsService;
            _bscScanTransactionService = bscScanTransactionService;
            _bscScanBlocksService = bscScanBlocksService;
            _bscScanGethProxyService = bscScanGethProxyService;
            _bscScanTokensService = bscScanTokensService;
            _bscScanGasTrackerService = bscScanGasTrackerService;
        }

        public async Task<IActionResult> Index()
        {
            // var test = await _bscScanService.GetBalanceAsync("0x70F657164e5b75689b64B7fd1fA275F334f28e18");

            //var test = await _bscScanService.GetBnbBalanceAsync(new BnbBalanceRequest
            //{
            //    Address = "0x70F657164e5b75689b64B7fd1fA275F334f28e18"
            //});
            // _logger.LogInformation("Bnb Balance", test);
            // string[] addresses = new[] { "0x70F657164e5b75689b64B7fd1fA275F334f28e18", "0x3f349bBaFEc1551819B8be1EfEA2fC46cA749aA1" };
            //var test1 = await _bscScanService.GetMultipleBnbBalanceAsync(new MultipleBnbBalanceRequest
            //{
            //    Addresses = addresses
            //});
            //var txlist = await _bscScanService.GetNormalTransactionsByAddressAsync(new NormalTransactionRequest
            //{
            //    Address = "0xF426a8d0A94bf039A35CEE66dBf0227A7a12D11e"
            //});

            //var txtIn = await _bscScanService.GetInternalTransactionsByAddressAsync(new InternalTransactionRequest
            //{
            //    Address  = "0x0000000000000000000000000000000000001004"
            //});
            // var txtIn = await _bscScanService.GetInternalTransactionsByTransactionHashAsync("0x4d74a6fc84d57f18b8e1dfa07ee517c4feb296d16a8353ee41adc03669982028");

            //var txlist = await _bscScanService.GetInternalTransactionsByBlockRangeAsync(new InternalTransactionsByBlockRangeRequest
            //{
            //    StartBlock = 0,
            //    EndBlock = 2702578
            //});

            //var txlist = await _bscScanService.GetBep20TokenTransferEventsByAddress(new Bep20TokenTransferEventsRequest
            //{
            //    ContractAddress = "0xc9849e6fdb743d08faee3e34dd2d1bc69ea11a51",
            //    Address = "0x7bb89460599dbf32ee3aa50798bbceae2a5f7f6a"
            //});
            //var txlist = await _bscScanService.GetBep721TokenTransferEventsByAddress(new Bep721TokenTransferEventsRequest
            //{
            //    ContractAddress = "0x5e74094cd416f55179dbd0e45b1a8ed030e396a1",
            //    Address = "0xcd4ee0a77e09afa8d5a6518f7cf8539bef684e6c"
            //});

            //var txlist = await _bscScanService.GetBlocksValidatedByAddress(new BlocksValidatedRequest
            //{
            //    Address = "0x78f3adfc719c99674c072166708589033e2d9afe"
            //});

            //  var txlist = await _bscScanService.GetHistoricalBnbBalanceByBlockNo("0x0DB011018728D1B91dDB3C77933a40B9B68C9fa7", 2000000);

            //contracts

            //var result = await _bscScanContractsService
            //    .GetContractApplicationBinaryInterface("0x0e09fabb73bd3ade0a17ecc321fd13a19e81ce82")
            //    .ConfigureAwait(false);

            //var resulta =
            //    await _bscScanTransactionService.CheckTransactionReceiptStatus(
            //        "0xe9975702518c79caf81d5da65dea689dcac701fcdd063f848d4f03c85392fd00");

            //var result = await _bscScanBlocksService.GetDailyBlockRewards(new DailyBlockCountAndRewardRequest
            //{
            //    StartDate = new DateOnly(2021,08,01),
            //    EndDate = new DateOnly(2021,08,31)
            //});
            //var result = await _bscScanGethProxyService.EthGetBlockByNumber("0xa11446").ConfigureAwait(false);
            //var result = await _bscScanGethProxyService.EthGetBlockTransactionCountByNumber("0xa11446");
            //var result = await _bscScanGethProxyService.EthGetTransactionByHash("0x9983332a52df5ad1dabf8fa81b1642e9383f302a399c532fc47ecb6a7a967166");
            // var resultt = await _bscScanGethProxyService.EthGetTransactionByBlockNumberAndIndex("0xa11446", "0x1");
            //var result = await _bscScanGethProxyService.EthGetTransactionCount("0x4430b3230294D12c6AB2aAC5C2cd68E80B16b581");
            //var result = await _bscScanGethProxyService.EthSendRawTransaction("0xf904808000831cfde080");
            //var result =
            //    await _bscScanGethProxyService.EthGetTransactionReceipt(
            //        "0x2122b2317d6cf409846f80e829c1e45ecb30306907ba0a00a02730c78890739f");
            //var result = await _bscScanGethProxyService.EthCall("0xAEEF46DB4855E25702F8237E8f403FddcaF931C0",
            //    "0x70a08231000000000000000000000000e16359506c028e51f16be38986ec5746251e9724");
            //var result = await _bscScanGethProxyService.EthGetCode("0x0e09fabb73bd3ade0a17ecc321fd13a19e81ce82");
            //var result =
            //    await _bscScanGethProxyService.EthGetStorageAt("0x0e09fabb73bd3ade0a17ecc321fd13a19e81ce82", "0x0");
            //var result = await _bscScanGethProxyService.EthGasPrice();
            //var result = await _bscScanGethProxyService.EthEstimateGas(new EthEstimateGasRequest
            //{
            //    Data = "0x4e71d92d",
            //    To = "0xEeee7341f206302f2216e39D715B96D8C6901A1C",
            //    Value = "0xff22",
            //    GasPrice = "0x51da038cc",
            //    Gas = "0x5f5e0ff"
            //});

            //var result =
            //    await _bscScanTokensService.GetBep20TokenTotalSupplyByContractAddress(
            //        "0xe9e7cea3dedca5984780bafc599bd69add087d56");

            //var result =
            //    await _bscScanTokensService.GetBep20TokenCirculatingSupplyByContractAddress(
            //        "0xe9e7cea3dedca5984780bafc599bd69add087d56");

            //var result = await _bscScanTokensService
            //    .GetBep20TokenAccountBalanceByContractAddress("0xe9e7cea3dedca5984780bafc599bd69add087d56", "0x89e73303049ee32919903c09e8de5629b84f59eb");
            // var test1 = await _bscScanService.GetMultipleBalanceAsync(addresses, Tag.Latest );

            // var result = await _bscScanTokensService.GetTokenHolderListByContractAddress(new TokenHolderListRequest
            //{
            //    ContractAddress = "0x0e09fabb73bd3ade0a17ecc321fd13a19e81ce82"
            //});

            // var result = await _bscScanGasTrackerService.GetGasOracle();

            var result = await _bscScanGasTrackerService.GetDailyAverageGasLimit(new DailyAverageGasLimitRequest
            {
                StartDate = new DateOnly(2021,8,1),
                EndDate = new DateOnly(2021,8,28)
            });
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}