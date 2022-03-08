using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Models;
using Vet.Data;
using Vet.MyModels;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace Vet.Controllers
{
    public class InformationController : Controller
    {
        StoreContext Dbcon = null;

        public InformationController(StoreContext Db)
        {
            Dbcon = Db;
        }


        //Busca el registro de todas las mascotas.
        public IActionResult Index()
        {
            //Metodo1: var ListPets = Dbcon.Pets.ToList();

            //Metodo 2
            //List<Pet> lst = null;
            //lst = (from data in Dbcon.Pets
            //     select new Pet
            //{
            //       Name = data.Name,
            //     Image = data.Image,
            //   BirthDate = data.BirthDate,
            // Age = data.Age,
            //Sex = data.Sex,
            //Specie = data.Specie,
            //Race = data.Race,
            //Color = data.Color,
            //weight = data.weight,
            //Comment = data.Comment
            //}).ToList();
            //var ownerPet = Dbcon.Owners.GroupJoin(Dbcon.Pets, ow => ow.OwnerId, pt => pt.OwnerId, (ow, pt) => new { ow, pt} ).ToList();
            var lst = Dbcon.Pets.ToList();
            return View(lst);
        }

        //Busca el registro de todos los propietarios
        public IActionResult ShowOwner()
        {
            List<Owner> lst = null;
            
            lst = (from data in Dbcon.Owners
                   select new Owner
                   {
                       OwnerId = data.OwnerId,
                       NameOwner = data.NameOwner,
                       HomeAddress = data.HomeAddress,
                       Cellphone = data.Cellphone
                   }).ToList();
             //var lst = Dbcon.Owners.ToList();
            return View(lst);
        }

        //Busca un propietario especifico
        [HttpPost]
        public IActionResult ShowOwner(int ownerId)
        {
            return Json(Dbcon.Owners.Where(ow => ow.OwnerId == ownerId));
        }

        //Busca las mascotas que le pertenecen a un propietario
        [HttpPost]
        public IActionResult MyPet(int ownerId)
        {
            var oPet = Dbcon.Pets.Where(p => p.OwnerId == ownerId).ToList();
            return Json(oPet);
        }

        //Busca un registro donde este asociado el ID del propietario con el ID de la mascota
        //Es decir, busca las mascotas que le pertenecen a cada propietario
        public IActionResult OwnerPet()
        {
            //List<Pet> lst = null;
            var lst = (from owners in Dbcon.Owners join pets in Dbcon.Pets
                   on owners.OwnerId equals pets.OwnerId
                       select new Info
                       {
                           OwnerId = owners.OwnerId,
                           PetId = pets.PetId,
                           Name = owners.NameOwner,
                           HomeAddress = owners.HomeAddress,
                           Cellphone = owners.Cellphone,
                           PetName = pets.Name,
                           Image = pets.Image,
                           BirthDate = pets.BirthDate,
                           Age = pets.Age, 
                           Sex = pets.Sex,
                           Race = pets.Race, Specie = pets.Specie, Color = pets.Color,
                           weight = pets.weight, Comment = pets.Comment

                       }).ToList();

            return View(lst);
            //return View(Dbcon.Owners.Join(Dbcon.Pets, ow => ow.OwnerId, pt => pt.OwnerId, (ow, pt) => new { ow, pt }).ToList());
        }

        //Accedemos por ajax a esta accion. El dato que recibe no lo usamos solo lo tenemos porque se envia como parametro de ajax.
        [HttpPost]
        public IActionResult OwnerPet(int dataTest)
        {
            var lst = (from owners in Dbcon.Owners
                       join pets in Dbcon.Pets
                            on owners.OwnerId equals pets.OwnerId
                       select new Info
                       {
                           OwnerId = owners.OwnerId,
                           PetId = pets.PetId,
                           Name = owners.NameOwner,
                           HomeAddress = owners.HomeAddress,
                           Cellphone = owners.Cellphone,
                           PetName = pets.Name,
                           Image = pets.Image,
                           BirthDate = pets.BirthDate,
                           Age = pets.Age,
                           Sex = pets.Sex,
                           Race = pets.Race,
                           Specie = pets.Specie,
                           Color = pets.Color,
                           weight = pets.weight,
                           Comment = pets.Comment

                       }).ToList();

            return Json(lst);
            //return View(Dbcon.Owners.Join(Dbcon.Pets, ow => ow.OwnerId, pt => pt.OwnerId, (ow, pt) => new { ow, pt }).ToList());
        }

        public IActionResult ByOwner()
        {
            return View();
        }

        //Busca un registro segun el nombre del propietario.
        //Por lo tanto se obtiene el registro de todas las mascotas que le pertenecen a ese propietario
        [HttpPost]
        public IActionResult ByOwner(string nameOwner)
        {
            var bynameOwner = Dbcon.Owners.Where(b => b.NameOwner == nameOwner);
            var lst = (from owners in bynameOwner
                       join pets in Dbcon.Pets on owners.OwnerId equals pets.OwnerId 
                       select new Info
                       {
                           OwnerId = owners.OwnerId,
                           PetId = pets.PetId,
                           Name = owners.NameOwner,
                           HomeAddress = owners.HomeAddress,
                           Cellphone = owners.Cellphone,
                           PetName = pets.Name,
                           Image = pets.Image,
                           BirthDate = pets.BirthDate,
                           Age = pets.Age,
                           Sex = pets.Sex,
                           Race = pets.Race,
                           Specie = pets.Specie,
                           Color = pets.Color,
                           weight = pets.weight,
                           Comment = pets.Comment

                       }).ToList();
       
            return Json(lst);

        }

        //Busca un registro segun el nombre de la mascota y el nombre del propietario
        [HttpPost]
        public IActionResult OnetoOne(Info data)
        {
            var bynamePet = Dbcon.Pets.Where(p => p.Name == data.PetName);
            var bynameOwner = Dbcon.Owners.Where(o => o.NameOwner == data.Name);
            var lst = (from owners in bynameOwner
                       join pets in bynamePet on owners.OwnerId equals pets.OwnerId
                       select new Info
                       {
                           OwnerId = owners.OwnerId,
                           PetId = pets.PetId,
                           Name = owners.NameOwner,
                           HomeAddress = owners.HomeAddress,
                           Cellphone = owners.Cellphone,
                           PetName = pets.Name,
                           Image = pets.Image,
                           BirthDate = pets.BirthDate,
                           Age = pets.Age,
                           Sex = pets.Sex,
                           Race = pets.Race,
                           Specie = pets.Specie,
                           Color = pets.Color,
                           weight = pets.weight,
                           Comment = pets.Comment

                       }).ToList();
            return Json(lst);

        }

        //Busca un registro de una mascota para asociarlo con su propietario
        [HttpPost]
        public IActionResult ByPet(string namePet)
        {
            var bynamePet = Dbcon.Pets.Where(p => p.Name == namePet);
            var lst = (from pets in bynamePet
                       join owners in Dbcon.Owners on pets.OwnerId equals owners.OwnerId
                       select new Info
                       {
                           OwnerId = owners.OwnerId,
                           PetId = pets.PetId,
                           Name = owners.NameOwner,
                           HomeAddress = owners.HomeAddress,
                           Cellphone = owners.Cellphone,
                           PetName = pets.Name,
                           Image = pets.Image,
                           BirthDate = pets.BirthDate,
                           Age = pets.Age,
                           Sex = pets.Sex,
                           Race = pets.Race,
                           Specie = pets.Specie,
                           Color = pets.Color,
                           weight = pets.weight,
                           Comment = pets.Comment

                       }).ToList();
            return Json(lst);

        }

        //Busca un registro de un propietario y una mascota especifico segun su ID.
        [HttpPost]
        public IActionResult SearchOwnerPet(int petId)
        {
            var oPet = Dbcon.Pets.Where(p => p.PetId == petId);
            var lst = (from pets in oPet join owners in Dbcon.Owners on pets.OwnerId equals owners.OwnerId
                       select new Info
                       {
                           Name = owners.NameOwner,
                           PetName = pets.Name
                       }).ToList();
                      
            return Json(lst);
        }
    }
}
