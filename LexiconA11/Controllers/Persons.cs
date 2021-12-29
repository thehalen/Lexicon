﻿using LexiconA11.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconA11.Controllers
{
    public class Persons : Controller
    {
        public IActionResult Index()        {

            //PeopleViewModel persons = new PeopleViewModel();
            if (PeopleViewModel.PersonsListView.Count < 1)
            {
                PeopleViewModel.MakePeople();
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(CreatePersonViewModel personVM)
        {
            PeopleViewModel peopleViewModel = new();

            peopleViewModel.AddPerson(personVM.Name,
                                      personVM.City,
                                      personVM.PhoneNr) ;
            if (ModelState.IsValid)
            {
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeletePerson(int id)
        {
            PeopleViewModel.DeletePerson(id);
            return RedirectToAction("Index");
        }
    }
}
