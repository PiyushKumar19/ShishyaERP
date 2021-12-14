using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShishyaERP.Models.InterfacesAndCRUD
{
    public class TeachersCRUD : ITeachersCRUD
    {
        private readonly DatabaseContext context;

        public TeachersCRUD(DatabaseContext databaseContext)
        {
            this.context = databaseContext;
        }
        public Teachers addTeach(Teachers teach)
        {
            context.TTeachers.Add(teach);
            context.SaveChanges();
            return teach;
        }

        public Teachers deleteTeach(int Id)
        {
            Teachers te = context.TTeachers.Find(Id);
            if(te!=null)
            {
                context.TTeachers.Remove(te);
                context.SaveChanges();
            }
            return te;
        }

        public IEnumerable<Teachers> getDataTeach()
        {
            return context.TTeachers;
        }

        public Teachers getIdTeach(int Id)
        {
            return context.TTeachers.Find(Id);
        }

        public Teachers updateTeacher(Teachers teachup)
        {
            var tup = context.TTeachers.Attach(teachup);
            tup.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return teachup;
        }
    }
}
