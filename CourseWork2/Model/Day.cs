using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace CourseWork2.Model
{
    public class Day
    {
        public List<Lesson> Lessons { get; }
        public DateTime Date { get; set; }

        public void AddLesson(Lesson lesson)
        {
            Lessons.Add(lesson);
        }
        public void RemoveLesson(Lesson lesson)
        {
            Lessons.Remove(lesson);
        }
    }
}
