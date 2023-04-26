using System.Collections.Generic;
using System.Windows.Documents;

namespace CourseWork2.Model
{
    public class Day
    {
        private List<Lesson> _lessons = new();
        public int Id { get; set; }
        public string Name { get; set; }
        public Day( int id, string name)
        {
            Id = id;
            Name = name ?? throw new System.ArgumentNullException(nameof(name));
        }
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
