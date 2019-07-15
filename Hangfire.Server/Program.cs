using System;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.PostgreSql;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Hangfire.Server
{
    class Program
    {
        static async Task Main(string[] args)
        {            
            GlobalConfiguration.Configuration.UsePostgreSqlStorage("Server=postgresql;Port=5432;Database=demo;User Id=demo; Password=111111;");
            
            using (var server = new BackgroundJobServer(new BackgroundJobServerOptions()
            {
                WorkerCount = 1
            }))
            {
                //Console.WriteLine("Hangfire Server started. Press any key to exit...");
                var hostBuilder = new HostBuilder()
                    // Add configuration, logging, ...
                    .ConfigureServices((hostContext, services) =>
                    {
                        
                        // Add your services with depedency injection.
                    });
                    
                    
                await hostBuilder.RunConsoleAsync();
            }

        }
    }
}
