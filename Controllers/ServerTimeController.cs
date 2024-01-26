using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    public class ServerTimeController : Controller
    {
        public IActionResult Time()
        {
            return View();
        }
    }



}
