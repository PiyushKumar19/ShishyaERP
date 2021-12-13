using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShishyaERP.Models.InterfacesAndCRUD
{
    public class StudentsCRUD : IStudentsCRUD
    {
        private readonly DatabaseContext context;

        public StudentsCRUD(DatabaseContext databaseContext)
        {
            this.context = databaseContext;
        }
        public Students addStu(Students stu)
        {
            context.TStudents.Add(stu);
            context.SaveChanges();
            return stu;
        }

        public Students deleteStu(int Id)
        {
            Students st = context.TStudents.Find(Id);
            if(st!=null)
            {
                context.TStudents.Remove(st);
                context.SaveChanges();
            }
            return st;
        }

        public IEnumerable<Students> getDataStu()
        {
            return context.TStudents;
        }

        public Students getIdStu(int Id)
        {
            return context.TStudents.Find(Id);
        }

        public Students updateStudent(Students stuup)
        {
            var sup = context.TStudents.Attach(stuup);
            sup.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return stuup;
        }
    }
}
