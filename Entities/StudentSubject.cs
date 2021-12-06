using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{

    //In Entity Framework Core, while configuting many to many relationship - we have to create a joining entity for a joining table (StudentSubject).
    //This class contains the foreign keys and navigational properties from the Student and Subject classes.
    //Furthermore, the Student and Subject classes both have navigational ICollection properties towards the StudentSubject class.
    //So basically, the Many-to-Many relationship is just two One-To-Many relationships.
    public class StudentSubject
    {
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
