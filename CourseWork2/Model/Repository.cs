using CourseWork2.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Model
{
    public class Repository : IRepository
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

        private List<Lesson> lessons = new List<Lesson>();
        private List<Day> days = new List<Day>();
        private List<Room> rooms = new List<Room>();
        private List<Interval> intervals = new List<Interval>();
        private List<Teacher> teachers = new List<Teacher>();

        #region Методы добавления данных
        public void AddLesson(Lesson lesson)
        {
            lessons.Add(lesson);
        }
        public void AddDay(Day day)
        {
            days.Add(day);
        }
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public void AddInterval(Interval interval)
        {
            intervals.Add(interval);
        }
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        #endregion

        #region Методы удаления данных
        public void RemoveLesson(Lesson lesson)
        {
            lessons.Remove(lesson);
        }
        public void RemoveDay(Day day)
        {
            days.Remove(day);
        }
        public void RemoveRoom(Room room)
        {
            rooms.Remove(room);
        }
        public void RemoveInterval(Interval interval)
        {
            intervals.Remove(interval);
        }
        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
        }

        public List<Lesson> GetLessons()
        {
            return lessons;
        }

        public List<Day> GetDays()
        {
            return days;
        }

        public List<Room> GetRooms()
        {
            return rooms;
        }

        public List<Interval> GetIntervals()
        {
            return intervals;
        }

        public List<Teacher> GetTeachers()
        {
            return teachers;
        }

        #endregion

    }
}
