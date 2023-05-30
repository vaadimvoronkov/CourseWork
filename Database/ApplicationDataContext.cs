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
        public DbSet<Day> Days { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Interval> Intervals { get; set; }
        public DbSet<Room> Rooms { get; set; } 
        public DbSet <Teacher> Teachers { get; set; }

        public ApplicationDataContext() 
        { 
            Database.EnsureCreated(); 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Day>(x =>
            {
                x.HasKey("DayId");
                x.Property(x => x.Date);
                x.HasMany(x => x.Lessons);
            });
            modelBuilder.Entity<Lesson>(x =>
            {
                x.HasKey("LessonId");
                x.Property(x => x.Name);
                x.Property(x => x.Task);
                x.Property(x => x.Progress);
                x.HasOne(x => x.Interval);
                x.HasOne(x => x.Teacher);
                x.HasOne(x => x.Room);
                x.HasOne(x => x.Day);
            });
            modelBuilder.Entity<Room>(x =>
            {
                x.HasKey("RoomId");
                x.Property(x => x.Number);
                x.HasMany(x => x.Lessons);
            });
            modelBuilder.Entity<Interval>(x =>
            {
                x.HasKey("IntervalId");
                x.Property(x => x.FirstTimeHour);
                x.Property(x => x.FirstTimeMinute);
                x.Property(x => x.LastTimeHour);
                x.Property(x => x.LastTimeMinute);
            });
            modelBuilder.Entity<Teacher>(x =>
            {
                x.HasKey("TeacherId");
                x.Property(x => x.FirstName);
                x.Property(x => x.SecondName);
                x.Property(x => x.Surname);
                x.HasMany(x => x.Lessons);
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocaldb;Database = CourseWorkDB;Trusted_Connection=True");
        }

    }
}
