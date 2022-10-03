using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homwork.Controllers
{
    public class Homework1Controller : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
