using System;

namespace Database.Tables
{
    public class LessonDB
    {
        public int LessonId { get; set; }
        public string Name { get; set; }
        public string Task { get; set; }
        public bool Progress { get; set; }

        public int IntervalId { get; set; }
        public virtual IntervalDB Interval { get; set; }
        public int TeacherId { get; set; }
        public virtual TeacherDB Teacher { get; set; }
        public int RoomId { get; set; }
        public virtual RoomDB Room { get; set; }
        public int DayId { get; set; }
        public virtual DayDB Day { get; set; }

    }
}
