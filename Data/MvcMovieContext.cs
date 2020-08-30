using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
// this data folder will house the data 
//A database context class is needed to coordinate 
//    EF Core functionality(Create, Read, Update, Delete) for the Movie model.
//    The database context is derived from Microsoft.EntityFrameworkCore.DbContext and 
//    specifies the entities to include in the data model.A database context class is needed to 
//    coordinate EF Core functionality(Create, Read, Update, Delete) for the Movie model.
//    The database context is derived from Microsoft.EntityFrameworkCore.DbContext 
//    and specifies the entities to include in the data model.

    //this is where we define the namespace. we can reference to it using namespace and the name
namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}



//The preceding code creates a DbSet<Movie> property for the entity set.In Entity Framework terminology, 
//    an entity set typically corresponds to a database table.An entity corresponds to a row in the table.