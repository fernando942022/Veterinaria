using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Data;
using Vet.Models;

namespace Vet.Controllers
{
    public class PayController : Controller
    {
        StoreContext Dbcon = null;

        public PayController(StoreContext con)
        {
            Dbcon = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int consultId)
        {
            return Json(Dbcon.Pays.Where(p => p.ConsultId == consultId));
        }

        [HttpPost]
        public IActionResult Add(Pay model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Dbcon.Pays.Add(model);
            Dbcon.SaveChanges();
            return Json(1);
        }
    }
}
