using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconA11.Models
{
    public class CountryModel
    {
        [Key]
        public static int Id = 0;
        public string Name { get; set; }
        public List<CityModel> Cities { get; set; }

        public static int GetNewID()
        {
            return Id++;
        }


        public CountryModel()
        {
            Id = GetNewID();
        }
    }
}
