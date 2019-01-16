using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        Lucky7 luck7 = new Lucky7();
        public IActionResult Index(int luck)
        {
            return new ContentResult { Content = luck7.Output(luck), ContentType = "text/html" };
        }
    }
}