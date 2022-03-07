using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Models;
using Vet.Data;

namespace Vet.Controllers
{
    public class PetController : Controller
    {
        StoreContext Dbcon = null;

        public PetController(StoreContext db)
        {
            Dbcon = db;
        }

        [HttpPost]
        public IActionResult Index(int PetId)
        {
            //var oPet = Dbcon.Pets.Where(op => op.PetId == PetId).ToList();
            return Json(Dbcon.Pets.Where(op => op.PetId == PetId));
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Pet model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Dbcon.Pets.Add(model);
            Dbcon.SaveChanges();

            return Json("Data saved..");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Pet model)
        {
            var oPet = Dbcon.Pets.Find(model.PetId);
            oPet.Name = model.Name;
            oPet.Image = model.Image;
            oPet.BirthDate = model.BirthDate;
            oPet.Age = model.Age;
            oPet.Sex = model.Sex;
            oPet.Specie = model.Specie;
            oPet.Race = model.Race;
            oPet.Color = model.Color;
            oPet.weight = model.weight;
            oPet.Comment = model.Comment;
            
            Dbcon.Entry(oPet).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Dbcon.SaveChanges();

            //return Redirect(Url.Content("~/Information/ShowOwner"));
            return Json("Saved data...");
        }

        //Obtiene el registro de todas las masacotas. Recibe un dato int el cual no utilizamos, solomente se envia como parte del ajax
        //[HttpPost]
        //public IActionResult ShowPets(int dataTest)
        //{
          //  return Json(Dbcon.Pets.ToList());
        //}
    }
}
