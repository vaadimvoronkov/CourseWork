using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Tables;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class ApplicationDataContext: DbContext
    {
        public DbSet<DayDB> Days { get; set; }
        public DbSet<LessonDB> Lessons { get; set; }
        public DbSet<IntervalDB> Intervals { get; set; }
        public DbSet<RoomDB> Rooms { get; set; } 
        public DbSet <TeacherDB> Teachers { get; set; }

        public ApplicationDataContext() 
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocaldb;Database = CourseWorkDB;Trusted_Connection=True");
        }

    }
}
