using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolApp.Database
{
    class SchoolDatabaseContext : DbContext
    {
        public DbSet<SchoolClass> SchoolClasses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName = SchoolDatabase.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
