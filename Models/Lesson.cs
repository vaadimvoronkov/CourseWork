using System;

namespace Models
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string Name { get; set; }
        public string Task { get; set; }
        public bool Progress { get; set; }

        public int IntervalId { get; private set; }
        public virtual Interval Interval { get; set; }
        public int TeacherId { get; private set; }
        public virtual Teacher Teacher { get; set; }
        public int RoomId { get; private set; }
        public virtual Room Room { get;  set; }
        public int DayId { get;  private set; }
        public virtual Day Day { get; set; }

        public static LessonBuilder CreateBuilder()
        {
            return new LessonBuilder();
        }

    }
}
