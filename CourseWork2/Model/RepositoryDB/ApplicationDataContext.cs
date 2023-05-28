using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CourseWork2.Model.Repository
{
    internal class ApplicationDataContext: DbContext
    {
        public DbSet<Day> Days { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Interval> Intervals { get; set; }
        public DbSet<Room> Rooms { get; set; } 
        public DbSet <Teacher> Teachers { get; set; }

        public ApplicationDataContext() 
        { 
            Database.EnsureCreated(); 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server={localdb}\\mssqllocaldb;Database = CourseWorkDB;Trusted_Connection=True");
        }


    }
}
