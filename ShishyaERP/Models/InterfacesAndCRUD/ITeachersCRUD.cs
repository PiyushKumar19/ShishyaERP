using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShishyaERP.Models.InterfacesAndCRUD
{
    public interface ITeachersCRUD
    {
        public Teachers getIdTeach(int Id);
        IEnumerable<Teachers> getDataTeach();
        Teachers addTeach(Teachers teach);
        Teachers deleteTeach(int Id);
        Teachers updateTeacher(Teachers teachup);
    }
}
