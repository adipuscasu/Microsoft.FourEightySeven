using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace Microsoft.FourEightySeven.WebAPI.ConsoleHose
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Starting Web API Server. Please wait...");
            if (typeof(Controllers.CustomersController) == null)
            {
                // work-around
                return;
            }
            var hostConfig = new HttpSelfHostConfiguration("http://localhost:8080");
            hostConfig.Routes.MapHttpRoute("API Name",
                " {controller}/{action}/{id}",
                new { id = RouteParameter.Optional });
            using (HttpSelfHostServer server = new HttpSelfHostServer(hostConfig))
            {
                server.OpenAsync().Wait();
                Console.WriteLine("Press [ENTER] to close");
                Console.ReadLine();
                server.CloseAsync().Wait();
            }
        }
    }
}
