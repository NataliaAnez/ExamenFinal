using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Examen_Final.Controllers
{
    public class LiteralController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}