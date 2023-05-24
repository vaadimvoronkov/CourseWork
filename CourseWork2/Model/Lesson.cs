using System;

namespace CourseWork2.Model
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Task { get; set; }
        public bool Progress { get; set; }
        public DateTime FirstTime { get; set; }
        public DateTime LastTime { get; set; }
        public Teacher Teacher { get; set; }
        public Room Room { get; set; }

        public int DayId { get; set; }
        public virtual Day Day { get; set; }

        public Lesson(string name, string task, bool progress, DateTime firstTime, DateTime lastTime, Day day) 
        { 
            Name= name;
            Task= task;
            Progress= progress;
            FirstTime = firstTime;
            LastTime = lastTime;
            Day = day;
        }

    }
}
