using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vet.Controllers
{
    public class PayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
