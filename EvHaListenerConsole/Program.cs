using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace EvHaListenerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = string.Format("http://0.0.0.0:{0}", ConfigurationManager.AppSettings["portnumber"]);
            var config = new HttpSelfHostConfiguration(url);

            config.Routes.MapHttpRoute(
                "API Default", "api/{controller}");

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.ResetColor();

                Console.WriteLine(string.Format("Client started on port {0}", ConfigurationManager.AppSettings["portnumber"]));
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
