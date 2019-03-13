// using System;
using Microsoft.AspNetCore.Hosting;
namespace commons.Services
{
    public class ServiceHost : IServiceHost
    {
        private readonly IWebHost _webHost;
        public ServiceHost(IWebHost webHost){
            _webHost = webHost;
        }

        public void Run() => _webHost.Run();
        
        public static HostBuilder Create<TStartup>(string[] args) where TStartup : class {
            Console.Title = typeof(TStartup).Namespace;
            
            
            var config = new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .AddCommandLine(args)
            .Build();
         
            var webHostBuilder = WebHost
        }
        
    }
}