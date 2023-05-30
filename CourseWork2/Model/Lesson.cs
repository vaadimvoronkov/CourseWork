using System;

namespace CourseWork2.Model
{
    public class Lesson
    {
        public int LessonId { get; private set; }
        public string Name { get; set; }
        public string Task { get; set; }
        public bool Progress { get; set; }

        public int IntervalId { get; private set; }
        public virtual Interval Interval { get; private set; }
        public int TeacherId { get; private set; }
        public virtual Teacher Teacher { get; private set; }
        public int RoomId { get; private set; }
        public virtual Room Room { get; private set; }
        public int DayId { get; private set; }
        public virtual Day Day { get; private set; }

        public Lesson(string name, string task, bool progress, Interval interval, Day day, Teacher teacher, Room room)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Task = task ?? throw new ArgumentNullException(nameof(task));
            Progress = progress;
            Interval = interval ?? throw new ArgumentNullException(nameof(interval));
            Day = day ?? throw new ArgumentNullException(nameof(day));
            Teacher = teacher ?? throw new ArgumentNullException(nameof(teacher));
            Room = room ?? throw new ArgumentNullException(nameof(room));
        }
    }
}
