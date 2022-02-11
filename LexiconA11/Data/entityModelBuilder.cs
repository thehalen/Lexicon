using LexiconA11.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconA11.Data
{
    public static class entityModelBuilder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonModel>().HasData(new PersonModel { Id = 1, Name = "NissE", City = "Malmö", PhoneNr = "09341" });
            modelBuilder.Entity<PersonModel>().HasData(new PersonModel { Id = 2, Name = "HassE", City = "Tjockholm", PhoneNr = "020KNDÖDEN" });
            modelBuilder.Entity<PersonModel>().HasData(new PersonModel { Id = 3, Name = "Bojan E", City = "London", PhoneNr = "123CALLING" });
        }
    }
}
