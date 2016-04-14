using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;

namespace EvHaListenerConsole
{
    [RoutePrefix("api/colors")]
    public class ColorsController : ApiController
    {
        [HttpPost]
        public async Task<IHttpActionResult> PostColorModel(MessageModel model)
        {
            var ctr = Counter.GetCounter();
            ctr.AddOne();
            ConsoleColor selectedColor = ConsoleColor.White;
            Console.ResetColor();
            Console.Write(ctr.getCount().ToString("D4"));
            Enum.TryParse(model.Color, out selectedColor);
            Console.BackgroundColor = selectedColor;
            Console.ForegroundColor = selectedColor;
            string displayer = string.Empty;
            for (int i = 0; i < model.Intensity; i++)
            {
                displayer += "_";
            }
            Console.WriteLine(displayer);

            return Ok();
        }
    }
}
