    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Database.Entitis;

namespace SchoolApp.Database
{
    //add-migration FirstMigration -outputdir Database\Migrations
    //update-database - tworzy obiekt typu FirstMigration i wowołuje metode Up
    //down  - wycofuje migracje, tworzy Alter Table
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
