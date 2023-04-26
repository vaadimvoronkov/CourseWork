namespace CourseWork2.Model
{
    public class Lesson
    {
        public string LessonName { get; set; }
        public string Task { get; set; }
        public TimeInterval Interval { get; set; }
        public bool Progress { get; set; }

        public Lesson(string lessonName, string task,TimeInterval interval)
        {
            LessonName = lessonName ?? throw new System.ArgumentNullException(nameof(lessonName));
            Task = task ?? throw new System.ArgumentNullException(nameof(task));
            Interval = interval ?? throw new System.ArgumentNullException(nameof(interval));
        }
    }
}
