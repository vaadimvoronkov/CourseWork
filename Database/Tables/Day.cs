using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Database.Tables
{
    public class Day
    {
        public int DayId { get; set; }
        public DateTime Date { get; set; }
        public virtual List<Lesson> Lessons { get; set; }
        public Day(DateTime date)
        {
            Date = date;
        }
    }
}
