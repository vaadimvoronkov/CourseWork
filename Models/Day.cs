using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;


namespace Models
{
    public class Day
    {
        public int DayId { get;  private set; }
        public DateTime Date { get; private set; }
        public virtual List<Lesson> Lesson { get; private set; }

        public Day(DateTime date)
        {
            Date = date;
        }
    }
}
