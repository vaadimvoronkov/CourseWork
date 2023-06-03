using System;

namespace CourseWork2.Model
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string Name { get; set; }
        public string Task { get; set; }
        public bool Progress { get; set; }

        public int IntervalId { get; set; }
        public virtual Interval Interval { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get;  set; }
        public int DayId { get;  set; }
        public virtual Day Day { get; set; }

        public static LessonBuilder CreateBuilder()
        {
            return new LessonBuilder();
        }
        //public Lesson(string name, string task, bool progress, Interval interval, Day day, Teacher teacher, Room room)
        //{
        //    Name = name ?? throw new ArgumentNullException(nameof(name));
        //    Task = task ?? throw new ArgumentNullException(nameof(task));
        //    Progress = progress;
        //    Interval = interval ?? throw new ArgumentNullException(nameof(interval));
        //    Day = day ?? throw new ArgumentNullException(nameof(day));
        //    Teacher = teacher ?? throw new ArgumentNullException(nameof(teacher));
        //    Room = room ?? throw new ArgumentNullException(nameof(room));
        //}
    }
}
