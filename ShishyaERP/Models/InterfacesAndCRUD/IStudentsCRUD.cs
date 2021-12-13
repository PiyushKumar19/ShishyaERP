using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShishyaERP.Models.InterfacesAndCRUD
{
    public interface IStudentsCRUD
    {
        public Students getIdStu(int Id);
        IEnumerable<Students> getDataStu();
        Students addStu(Students stu);
        Students deleteStu(int Id);
        Students updateStudent(Students stuup);
    }
}
