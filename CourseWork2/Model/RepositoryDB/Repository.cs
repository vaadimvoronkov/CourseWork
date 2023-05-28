using CourseWork2.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Model.Repository
{
    public class Repository
    {
        private static Repository repository;
        private Repository() 
        {

        }
        public static Repository GetInstance()
        {
            if (repository == null)
                repository = new Repository();
            return repository;
        }

        public List<Lesson> lessons { get; }
        public List<Day> days { get; }
        public List<Room> rooms { get; }
        public List<Interval> intervals  { get; }
        public List<Teacher> teachers { get; }

        public void AddLesson(Lesson lesson)
        {
            lessons.Add(lesson);
        }
    }
}
