using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace CourseWork2.Model
{
    public class Diary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Day> Days { get; set; }


        public void AddDay(Day day)
        {
            Days.Add(day);
        }
        public void RemoveDay(Day day)
        {
            Days.Remove(day);
        }

        
    }
}
