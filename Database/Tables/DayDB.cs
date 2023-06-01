using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Database.Tables
{
    public class DayDB
    {
        public int DayId { get; set; }
        public DateTime Date { get; set; }
        public virtual List<LessonDB> Lessons { get; set; }
    }
}
