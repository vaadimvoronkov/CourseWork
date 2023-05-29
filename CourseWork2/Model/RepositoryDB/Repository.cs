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
        public List<Diary> diaries = new List<Diary>();

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
        public void AddDiary(Diary diary)
        {
            diaries.Add(diary);
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
        public void RemoveDiary(Diary diary)
        {
            diaries.Remove(diary);
        }
        #endregion
    }
}
