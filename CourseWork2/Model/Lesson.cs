using System;

namespace CourseWork2.Model
{
    public class Lesson
    {
        public string LessonName { get; set; }
        public string Task { get; set; }
        public bool Progress { get; set; }
        public TimeSpan FirstTime { get; set; }
        public TimeSpan LastTime { get; set; }
        public DateTime Date { get; set; }

        public Lesson(string lessonName, string task, bool progress, TimeSpan firstTime, TimeSpan secondTime, DateTime date)
        {
            LessonName = lessonName ?? throw new ArgumentNullException(nameof(lessonName));
            Task = task ?? throw new ArgumentNullException(nameof(task));
            Progress = progress;
            FirstTime = firstTime;
            LastTime = secondTime;
            Date = date;
        }
    }
}
