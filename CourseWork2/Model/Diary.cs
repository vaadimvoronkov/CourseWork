using System.Collections.Generic;
using System.Windows.Documents;

namespace CourseWork2.Model
{
    public class Diary
    {
        private List<Day> _days = new();
        public int Id { get; set; }
        public string Name { get; set; }
        public Diary(int id, string name)
        {
            Id = id;
            Name = name ?? throw new System.ArgumentNullException(nameof(name));
        }
        public void AddDay(Day day)
        {
            _days.Add(day);
        }
        public void RemoveDay(Day day)
        {
            _days.Remove(day);
        }

        
    }
}
