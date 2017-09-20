using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace lightswitch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
            // var config = new ConfigurationBuilder()
            // .SetBasePath(Directory.GetCurrentDirectory())
            // .Build();

            // var host = new WebHostBuilder()
            // .UseKestrel()
            // //.UseUrls("http://*:80")
            // .UseContentRoot(Directory.GetCurrentDirectory())
            // .UseStartup<Startup>()
            // .Build();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            // .UseUrls("http://*:80")
            // .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();
    }
}
