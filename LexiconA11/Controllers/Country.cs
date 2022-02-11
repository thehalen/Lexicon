using LexiconA11.Data;
using LexiconA11.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconA11.Controllers
{
    public class Country : Controller
    {
        private readonly ApplicationDbContext _context;

        public Country(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //PeopleViewModel personVM = new();
            //PeopleViewModel.listOfPeople = _context.People.ToList();
            return View();
        }
    }
}
