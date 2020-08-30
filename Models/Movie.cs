using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    //this is a POCO Class- 
    //The model classes you create are known as POCO classes(from Plain Old CLR Objects) 
    //    because they don't have any dependency on EF Core. They just define the properties 
    //    of the data that will be stored in the database.
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    //we will use the EF Core to map every POCO class to a database
}
