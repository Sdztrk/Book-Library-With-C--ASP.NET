using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace api.Models
{
    public class Book
    {
        public int Id {get; set;}

        public string Title {get; set;} = string.Empty;

        public int ISBN {get; set;}

        public string Genre {get; set;} = string.Empty;

        public int Number {get; set;}

    }
}