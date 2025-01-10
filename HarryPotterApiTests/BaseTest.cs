using HarryPotterApiService;
using HarryPotterApiService.Configurations;

using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.DependencyInjection;

using Serilog;

namespace HarryPotterApiTests
{
    public class BaseTest
    {
        protected ServiceProvider serviceProvider;

        public BaseTest()
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(TestContext.CurrentContext.TestDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            IServiceCollection services = new ServiceCollection()
                  .Configure<HarryPotterServiceSettings>(configurationRoot.GetSection(nameof(HarryPotterServiceSettings)))
                  .AddSingleton<HarryPotterApiClient>();

            this.serviceProvider = services.BuildServiceProvider();
        }

        [SetUp]
        public void SetUp()
        {
            Log.Logger = new LoggerConfiguration()
           .MinimumLevel.Verbose()
           .WriteTo.Console()
           .CreateLogger();
        }
    }
}
