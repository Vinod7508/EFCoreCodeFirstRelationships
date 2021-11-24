using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstDatabaseMigration.Entities
{

    //The context class is another important part of the application.
    //This class must inherit from the DbContext base class which contains information and configuration for accessing the database
    public class ApplicationContext : DbContext
    {
        //Our ApplicationContext class currently accepts one parameter of type DbContextOptions inside a constructor.
        //But we can provide the generic version of the DbContextOptions parameter as well:

        //public ApplicationContext(DbContextOptions options) : base(options)
        //{ }

        //generic version

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }

        //EF Core looks for all the public DbSet properties, inside the application’s context class, and then maps their names to the names of the tables in the database
        public DbSet<Student> Students { get; set; }

    }
}
