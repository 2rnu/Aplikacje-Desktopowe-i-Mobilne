using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolApp.Database
{
    class Program
    {
        static void Main(string[] args)
        {
            //DRUD
            SchoolDatabaseContext schoolDatabaseContext = new SchoolDatabaseContext();

        }
    }
}


//Odwzorowywanie bazy danych w C# - database first | core first
// database first - kiedy musimy się doczepić do istniejącej już bazy i działać właśnie niej ||
//code first - kiedy nie chcemy zarządzać bazą