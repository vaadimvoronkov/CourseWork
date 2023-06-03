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

    }
}
