using Microsoft.VisualBasic;
using Models;
using System;
using System.Collections.Generic;

namespace Database.Tables
{
    public class DayDB
    {
        public int DayId { get; set; }
        public DateTime Date { get; set; }
        public int LessonId { get; set; }
        public virtual List<LessonDB> Lesson { get; private set; }
    }
}
