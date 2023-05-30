using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace CourseWork2.Model
{
    public class Day
    {
        public int DayId { get; private set; }
        public DateTime Date { get; private set; }
        public List<Lesson> Lessons { get; private set; }
        public Day(DateTime date)
        {
            Date = date;
        }
    }
}
