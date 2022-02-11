using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconA11.Models
{
    public class PersonModel : CreatePersonViewModel
    {
        [Key]
        private new static int Id = 0;

        public static int GetNewID()
        {            
            return Id++;
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
