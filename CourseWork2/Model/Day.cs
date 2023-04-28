using System.Collections.Generic;
using System.Windows.Documents;

namespace CourseWork2.Model
{
    public class Day
    {
        private List<Lesson> _lessons = new();
        public List<Lesson> Lessons { get => _lessons; }

        public void AddLesson(Lesson lesson)
        {
            _lessons.Add(lesson);
        }
        public void RemoveLesson(Lesson lesson)
        {
            _lessons.Remove(lesson);
        }
    }
}
