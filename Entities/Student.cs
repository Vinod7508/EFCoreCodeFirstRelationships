﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    //Now, to establish a relationship between the Student and the StudentDetails classes we need to add a reference navigation property at both sides.
    //here student class is principal entity
    

    [Table("Student")]
    public class Student
    {
        //The model (entity) class is a class that Entity Framework Core uses for mapping to the database table. 
        //efcore naming convention...StudentIDd is primary key here

        //to configure a PrimaryKey property via the Data Annotations approach, we have to use the [Key] attribute...we can also use fluent api..check modelbuilderclass
        //[Key]
        [Column("StudentId")]
        public Guid Id { get; set; }

        //public Guid AnotherKeyProperty { get; set; }


        //we are using data anotation based entity framework configuration here here.
        [Required]
        [MaxLength(50, ErrorMessage = "Length mus be less then 50 characters")]
        public string Name { get; set; }
        public int? Age { get; set; }


        //The [NotMapped] attribute allows us to exclude certain properties from the mapping and thus avoid creating that column in a table.
        //we can do the same thing via the Fluent API approach..check modelbuilder method in applicationContext
        //[NotMapped]
        //public int LocalCalculation { get; set; }

        public bool IsRegularStudent { get; set; }

        public StudentDetails StudentDetails { get; set; }


        //Convention Approach to Create One-to-Many Relationship(Required not optional as we put studentid in evalution table)
        public ICollection<Evaluation> Evaluations { get; set; }


        //We modify Student by providing the navigational property towards the StudentSubject class:
        public ICollection<StudentSubject> StudentSubjects { get; set; }




    }
}
