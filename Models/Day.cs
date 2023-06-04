using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;


namespace Models
{
    public class Day
    {
        public int DayId { get;  set; }
        public DateTime Date { get; set; }
        public int LessonId { get; set; }
        public virtual List<Lesson> Lesson { get; set; }

        public Day(DateTime date)
        {
            Date = date;
        }
    }
}
