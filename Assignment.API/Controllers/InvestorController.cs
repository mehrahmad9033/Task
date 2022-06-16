using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.API.Controllers
{
    public class InvestorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}