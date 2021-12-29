using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconA11.Models
{
    public class PersonModel : CreatePersonViewModel
    {

        private static int id = 0;
        public static int GetNewID()
        {            
            return id++;
        }


        public PersonModel()
        {
            Id = GetNewID();
        }

        public PersonModel(string name, string city, string phonenr)
        {
            Name = name;
            City = city;
            PhoneNr = phonenr;
            Id = GetNewID();
        }



    }
}
