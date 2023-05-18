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
        public DateTime Date { get; set; }

    }
}
