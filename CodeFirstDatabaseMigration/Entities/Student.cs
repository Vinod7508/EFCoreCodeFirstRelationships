using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstDatabaseMigration.Entities
{
    public class Student
    {
        //The model (entity) class is a class that Entity Framework Core uses for mapping to the database table. 
        //efcore naming convention...StudentIDd is primary key here
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
