using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace BrokenApi
{
    public class Server
    {
        public static async Task Main(string[] args) => await Initialise(args);

        public static async Task<IWebHost> Initialise(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .Build();

            var hostBuilder = WebHost.CreateDefaultBuilder(args)
                .UseConfiguration(configuration)
                .UseStartup<Startup>();

            var webHost = hostBuilder.Build();
            await webHost.RunAsync();

            return webHost;
        }
    }
}