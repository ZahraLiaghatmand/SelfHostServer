using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace SelfHostServer.Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = "http://localhost:5000";

            var config = new HttpSelfHostConfiguration(baseAddress);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.WriteLine($"Self-hosted Web API running at {baseAddress}/api/");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
            }
        }
    }
}
