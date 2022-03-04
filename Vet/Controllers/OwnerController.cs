using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Models;
using Vet.Data;

namespace Vet.Controllers
{
    public class OwnerController : Controller
    {
        StoreContext con = null;

        public OwnerController(StoreContext dbCon)
        {
            con = dbCon;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(Owner model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            con.Owners.Add(model);
            con.SaveChanges();

            var oOwner = con.Owners.Where(c => c.Cellphone == model.Cellphone).First();
           // Owner oOwner = con.Owners.Max(id => id.OwnerId);
           
             return Json(oOwner.OwnerId);
        }

        [HttpPost]
        public IActionResult Edit(Owner model)
        {
            Owner oOwner = con.Owners.Find(model.OwnerId);
            oOwner.NameOwner = model.NameOwner;
            oOwner.HomeAddress = model.HomeAddress;
            oOwner.Cellphone = model.Cellphone;
            con.Entry(oOwner).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            con.SaveChanges();

            return Redirect(Url.Content("~/Information/ShowOwner"));
            //return View();
        }
    }
}
