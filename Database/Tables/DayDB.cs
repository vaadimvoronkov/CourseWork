using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Models;
using System;
using System.Collections.Generic;

namespace Database.Tables
{
    [PrimaryKey("DayId")]
    public class DayDB
    {

        public int DayId { get; set; }
        public DateTime Date { get; set; }
        public virtual List<LessonDB> Lesson { get; set; } = new();
    }
}
