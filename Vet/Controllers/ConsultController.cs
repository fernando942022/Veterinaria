using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Models;
using Vet.Data;
using PagedList;
using PagedList.Mvc;
using System.Web;

namespace Vet.Controllers
{
    public class ConsultController : Controller
    {
        StoreContext Dbcon = null;

        public ConsultController(StoreContext con)
        {
            Dbcon = con;
        }

        public IActionResult Index(int? pageSize, int? page)
        {
            //Se inicializan los valores de las variables en caso de que sean nulas
            pageSize = (pageSize ?? 5);
            page = (page ?? 1);
            ViewBag.PageSize = pageSize;

            return View(Dbcon.Consults.ToPagedList(page.Value, pageSize.Value));
        }

        //Buscamos una consulta especifica por medio de su id
        [HttpPost]
        public IActionResult Index(int consultId)
        {
            return Json(Dbcon.Consults.Where(c => c.ConsultId == consultId).ToList());
        }

        public IActionResult Add()
        {
            return View();
        }

        //Agregamos una nueva consulta y despues obtenemos el ultimo registro actualizado segun la fecha
        [HttpPost]
        public IActionResult Add(Consult model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Dbcon.Consults.Add(model);
            Dbcon.SaveChanges();

            //var lst = Dbcon.Consults.OrderByDescending(c => c.ConsultDate).FirstOrDefault(); 
            var lst = Dbcon.Consults.Where(c => c.ConsultDate == model.ConsultDate).ToList();
            return Json(lst);
        }

        //Buscamos las consultas de una mascota especifica
        [HttpPost]
        public IActionResult SearchConsult(int petId)
        {
            var lst = Dbcon.Consults.Where(c => c.PetId == petId).ToList();
            return Json(lst);
        }

        //Nueva consulta
        public IActionResult NewConsult()
        {
            return View();
        }
    }
}
