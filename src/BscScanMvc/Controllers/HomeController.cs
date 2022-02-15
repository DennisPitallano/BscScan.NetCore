using BscScanMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BscScan.NetCore;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Models;
using BscScan.NetCore.Models.Request.Account;

namespace BscScanMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IBscScanAccountService _bscScanService;

        public HomeController(ILogger<HomeController> logger, IBscScanAccountService bscScanService)
        {
            _logger = logger;
            _bscScanService = bscScanService;
        }

        public async Task<IActionResult> Index()
        {
            // var test = await _bscScanService.GetBalanceAsync("0x70F657164e5b75689b64B7fd1fA275F334f28e18");
            try
            {
                var test = await _bscScanService.GetBnbBalanceAsync(new BnbBalanceRequest
                {
                    Address = "0x70F657164e5b75689b64B7fd1fA275F334f28e18"
                });
                // _logger.LogInformation("Bnb Balance", test);
                string[] addresses = new[] { "0x70F657164e5b75689b64B7fd1fA275F334f28e18", "0x3f349bBaFEc1551819B8be1EfEA2fC46cA749aA1" };
                //var test1 = await _bscScanService.GetMultipleBnbBalanceAsync(new MultipleBnbBalanceRequest
                //{
                //    Addresses = addresses
                //});
                var txlist = await _bscScanService.GetNormalTransactionsByAddressAsync(new NormalTransactionRequest
                {
                    Address = "0xF426a8d0A94bf039A35CEE66dBf0227A7a12D11e"
                });
            }
            catch (HttpRequestException e)
            {
                throw e;
            }
            // var test1 = await _bscScanService.GetMultipleBalanceAsync(addresses, Tag.Latest );
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