using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
  public class Subject
    {
        [Column("SubjectId")]
        public Guid Id { get; set; }
        public string SubjectName { get; set; }

        //we modify Subject classes by providing the navigational property towards the StudentSubject class:
        public ICollection<StudentSubject> StudentSubjects { get; set; }

    }
}
