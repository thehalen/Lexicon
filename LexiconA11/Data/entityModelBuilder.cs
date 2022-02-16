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
            modelBuilder.Entity<PersonModel>().HasData(new PersonModel { PersonId = 1, Name = "NissE", CityId = 1, PhoneNr = "09341" });
            modelBuilder.Entity<PersonModel>().HasData(new PersonModel { PersonId = 2, Name = "HassE", CityId = 2, PhoneNr = "020KNDÖDEN" });
            modelBuilder.Entity<PersonModel>().HasData(new PersonModel { PersonId = 3, Name = "Bojan E", CityId = 3, PhoneNr = "123CALLING" });

            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { CountryId = 1, Name = "Turkiet" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { CountryId = 2, Name = "Somaliland" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { CountryId = 3, Name = "Sverige" });

            modelBuilder.Entity<CityModel>().HasData(new CityModel { CityId = 1, Name = "Ankara", CountryId = 1 });
            modelBuilder.Entity<CityModel>().HasData(new CityModel { CityId = 2, Name = "Istanbul", CountryId = 1 });
            modelBuilder.Entity<CityModel>().HasData(new CityModel { CityId = 3, Name = "Malmö", CountryId = 2 });
            modelBuilder.Entity<CityModel>().HasData(new CityModel { CityId = 4, Name = "Oslo", CountryId = 3 });
        }
    }
}
