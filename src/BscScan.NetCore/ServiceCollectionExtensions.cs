using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BscScan.NetCore.Configuration;
using BscScan.NetCore.Constants;
using BscScan.NetCore.Contracts;
using BscScan.NetCore.Extensions;
using BscScan.NetCore.Services;
using Microsoft.Extensions.Options;

namespace BscScan.NetCore;

public static class BscScanServiceCollectionExtensions
{
    public static void AddBscScan(this IServiceCollection? services, BscScanConfiguration bscScanConfiguration )
    {
        services?.AddHttpClient<IBscScanAccountService, BscScanAccountService>(client =>
        {
            client.BaseAddress = new Uri(bscScanConfiguration.BscScanOptions.Uri!);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        });
    }
}