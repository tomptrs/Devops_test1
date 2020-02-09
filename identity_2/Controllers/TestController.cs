using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace identity_2.Controllers
{
    public class TestController : Controller
    {
        /*
         * This is a test controller!!
         */
        public IActionResult Index()
        {
            return View();
        }
    }
}