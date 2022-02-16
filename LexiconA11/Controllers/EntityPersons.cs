using LexiconA11.Data;
using LexiconA11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconA11.Controllers
{
    public class EntityPersons : Controller
    {
        private readonly ApplicationDbContext _context;

        public EntityPersons(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PeopleViewModel personVM = new();

            personVM.listOfPeople = _context.People.Include(p => p.City).ToList();
            //PeopleViewModel.listOfPeople = _context.People.ToList();
            return View(personVM);
        }

        [HttpPost]
        public ActionResult AddPerson(PeopleViewModel personVM)
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(new PersonModel { Name = personVM.Name, CityId = personVM.CityId, PhoneNr = personVM.PhoneNr });
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult DeletePerson(int id)
        {
            var p = _context.People.Find(id);
            _context.Remove(p);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
