using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Data;
using Vet.Models;

namespace Vet.Controllers
{
    public class QuotaController : Controller
    {
        StoreContext Dbcon = null;

        public QuotaController(StoreContext con)
        {
            Dbcon = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Quota model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Dbcon.Quotas.Add(model);
            Dbcon.SaveChanges();

            return Json(1);
        }

        [HttpPost]
        public IActionResult ListQuota(int payId)
        {
            return Json(Dbcon.Quotas.Where(q => q.PayId == payId).ToList());
        }

    }
}
