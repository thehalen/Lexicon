using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconA11.Models
{
    public class CityModel
    {
        [Key]
        public static int Id = 0;
        public string Name { get; set; }
        public List<PersonModel> Persons { get; set; }
        public CountryModel Country { get; set; }
        public int CountryId { get; set; }

        public static int GetNewID()
        {            
            return Id++;
        }


        public CityModel()
        {
            Id = GetNewID();
        }
    }
}
