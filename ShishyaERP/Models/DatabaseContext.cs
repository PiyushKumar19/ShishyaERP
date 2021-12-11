using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShishyaERP.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Students> TStudents { get; set; }
        public DatabaseContext( DbContextOptions options) : base(options)
        {
        }
    }
}
