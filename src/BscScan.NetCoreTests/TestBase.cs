using System.IO;
using BscScan.NetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BscScan.NetCoreTests
{
    [TestClass]
    public class TestBase
    {
        internal IConfigurationRoot? ConfigurationRoot;
        internal ServiceCollection _services;
        internal ServiceProvider _serviceProvider;

        public TestBase()
        {
            var configurationBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddEnvironmentVariables();

            ConfigurationRoot = configurationBuilder.Build();
            
            _services = new ServiceCollection();

            ////We load EXACTLY the same settings (DI and others) than API real solution, what is much better for tests.
            _services.AddBscScan(ConfigurationRoot);


            _serviceProvider = _services.BuildServiceProvider();
        }

        ~TestBase()
        {
            if (_serviceProvider != null)
                _serviceProvider.Dispose();
        }
    }
}
