using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace APIGSB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseIISIntegration()
                .UseUrls("http://*:8200")
                .Build();
	        host.Run();           
        }
    }
}
