using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FortRoach
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
				IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>()
               .Build();
			
			
			
			
			// var config = new ConfigurationBuilder().AddEnvironmentVariables("").Build();

            // var url = config["ASPNETCORE_URLS"] ?? "http://*:8080";

            // var host = new WebHostBuilder()
            // .UseKestrel()
            // .UseContentRoot(Directory.GetCurrentDirectory())
            // .UseIISIntegration()
            // .UseStartup<Startup>()
            // .UseUrls(url) // 4th line added
            // .Build();

            // host.Run();
        }

        
    }
}
