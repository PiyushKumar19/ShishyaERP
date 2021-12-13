using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShishyaERP.Models
{
    public class Students
    {
        [Key]
        public int studentId { get; set; }
        public string studentName { get; set; }
        public string fatherName { get; set; }
        public string motherName { get; set; }
        public int age { get; set; }
        public GenderList gender { get; set; }
        public BloodGroupList bloodGroup { get; set; }
        [DataType(DataType.Date)]
        public DateTime dob { get; set; }
        public string address { get; set; }
        public string city { get; set; }
    }
}
