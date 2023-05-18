using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace CourseWork2.Model
{
    public class Diary
    {
        private List<Day> _days = new();
        public List<Day> Days { get => _days;}

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
