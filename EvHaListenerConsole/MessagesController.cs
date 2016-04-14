using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace EvHaListenerConsole
{
    [RoutePrefix("api/messages")]
    public class MessagesController : ApiController
    {
        [HttpPost]
        public async Task<IHttpActionResult> PostMessage()
        {
            string result = await Request.Content.ReadAsStringAsync();
            Console.ResetColor();
            Console.WriteLine("New message received: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(result);
            Console.WriteLine();
            Console.ResetColor();
            return Ok();
        }
    }
}
