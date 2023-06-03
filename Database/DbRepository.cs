using CourseWork2.Model;
using CourseWork2.ViewModel;
using Database.Tables;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DbRepository : IRepository
    {
        #region Методы добавления данных
        public void AddDay(Day day)
        {
            throw new NotImplementedException();
        }

        public void AddInterval(Interval interval)
        {
            throw new NotImplementedException();
        }

        public void AddLesson(Lesson lesson)
        {
            throw new NotImplementedException();
        }

        public void AddRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public void AddTeacher(Teacher teacher)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Методы получения данных

        public Day GetDay(Day day)
        {
            throw new NotImplementedException();
        }
        public Room GetRoom(Room room)
        {
            throw new NotImplementedException();
        }
        public Teacher GetTeacher(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public Interval GetInterval(Interval interval)
        {
            throw new NotImplementedException();
        }

        public List<Interval> GetIntervals()
        {
            throw new NotImplementedException();
        }
        public List<Day> GetDays()
        {
            throw new NotImplementedException();
        }

        public List<Room> GetRooms()
        {
            throw new NotImplementedException();
        }
        public List<Lesson> GetLessons()
        {
            List<Lesson> lessons = new();
            using (ApplicationDataContext db = new())
            {
                var lessonsDb = db.Lessons.ToList();
                foreach (var item in lessonsDb)
                {
                    lessons.Add
                    (
                        _ = Lesson.CreateBuilder()
                        .SetName(item.Name)
                        .SetTask(item.Task)
                        .SetProgress(item.Progress)
                        .SetInterval(new Interval(item.Interval.FirstTimeHour, item.Interval.FirstTimeMinute, item.Interval.LastTimeHour, item.Interval.LastTimeMinute))
                        .SetDay(new Day(item.Day.Date))
                        .SetTeacher(new Teacher(item.Teacher.FirstName, item.Teacher.SecondName, item.Teacher.Surname))
                        .SetRoom(new Room(item.Room.Number)).
                        Build()
                    );
                }
                return lessons;
            }
        }


        public List<Teacher> GetTeachers()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Методы удаления данных
        public void RemoveLesson(Lesson lesson)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
