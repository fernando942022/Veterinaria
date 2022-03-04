using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Models;
using Vet.Data;

namespace Vet.Controllers
{
    public class ConsultController : Controller
    {
        StoreContext Dbcon = null;

        public ConsultController(StoreContext con)
        {
            Dbcon = con;
        }

        [HttpPost]
        public IActionResult Index(Consult model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //Dbcon.Consults.Add.(model);
            //Dbcon.SaveChanges();
            return Json(1);
        }
    }
}
