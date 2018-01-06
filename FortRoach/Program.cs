﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FortRoach
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddEnvironmentVariables("").Build();
            // 2nd line added

            var url = config["ASPNETCORE_URLS"] ?? "http://*:8080";
            // 3rd line added

            var host = new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseIISIntegration()
            .UseStartup<Startup>()
            .UseUrls(url) // 4th line added
            .Build();

            host.Run();
        }
    }
}
    //public class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         BuildWebHost(args).Run();
    //     }

    //     public IWebHost BuildWebHost(string[] args) =>
    //         WebHost.CreateDefaultBuilder(args)
    //             .UseStartup<Startup>()
    //             .Build();
    // }
			
			
			
			
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
