using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{

    //The easiest way to configure one to one type of relationship is to use by the Convention approach
    //this studentdetails class is dependent entity which holds the foreign key that refers to the principal entity’s(student table) primary key

    //we dont need to declare dbset<T> property for studentdetails.cs class but it is still created in db.

    //EF Core searches for all the public DbSet<T> properties in the DbContext class to create tables in the database.
    //Then it searches for all the public properties in the T class to map the columns. 
    //But it also searches for all the public navigational properties in the T class and creates additional tables and columns related to the type of the navigation property.
    //So, in our example, in the Student class, EF Core finds the StudentDetails navigation property and creates an additional table with its columns.

    public class StudentDetails
    {
        [Column("StudentDetailsId")]
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string AdditionalInformation { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
