using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShishyaERP.Models
{
    public class Teachers
    {
        [Key]
        public int teacherId { get; set; }
        public string teacherName { get; set; }
        public int teacherAge { get; set; }
        public GenderList teacherGender { get; set; }
        public BloodGroupList bgroup { get; set; }
        public string teacherNo { get; set; }
        public string graduatedIn { get; set; }
        public string subject { get; set; }
        public string teacherAddress { get; set; }
        public string teachCity { get; set; }
    }
}
