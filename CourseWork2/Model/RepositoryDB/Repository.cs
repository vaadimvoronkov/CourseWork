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

        public List<Lesson> lessons = new List<Lesson>();
        public List<Day> days = new List<Day>();
        public List<Room> rooms = new List<Room>();
        public List<Interval> intervals = new List<Interval>();
        public List<Teacher> teachers = new List<Teacher>();

        public void AddLesson(Lesson lesson)
        {
            lessons.Add(lesson);
        }
    }
}
