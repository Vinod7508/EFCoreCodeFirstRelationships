using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{

    //The easiest way to configure one to one type of relationship is to use by the Convention approach
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
