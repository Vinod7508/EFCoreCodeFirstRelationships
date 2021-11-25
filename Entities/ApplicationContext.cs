using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
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
        


        //Using the Fluent API Approach--another type of entity framework configuration.
        //The Fluent API is a set of methods that we can use on the ModelBuilder class, which is available in the OnModelCreating method in our context (ApplicationContext) class.
        //OnModelCreating is called the first time our application instantiates the ApplicationContext class
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .ToTable("Student");
            modelBuilder.Entity<Student>()
                .Property(s => s.Id)
                .HasColumnName("StudentId");
            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Student>()
                .Property(s => s.Age)
                .IsRequired(false);

            //modelBuilder.Entity<Student>()
            //    .Ignore(s => s.LocalCalculation);

            //For the composite key, we have to use only the Fluent API approach because EF Core doesn’t support the Data Annotations approach for that.
            //modelBuilder.Entity<Student>()
            //.HasKey(s => new { s.Id, s.AnotherKeyProperty });

            //for adding indexes on db table...fluent api is only one approach

            // modelBuilder.Entity<Student>()
            //.HasIndex(s => s.Id)
            //.HasName("index_name")
            //.IsUnique();

            //configuration of default value for table column via the Fluent API:

            modelBuilder.Entity<Student>()
           .Property(s => s.IsRegularStudent)
           .HasDefaultValue(true);

        }

        public DbSet<Student> Students { get; set; }




    }
}
