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
using System.Windows.Media.Converters;

namespace Database
{
    public class DbRepository : IRepository
    {
        #region Методы добавления данных
        public Day AddDay(Day day)
        {
            DayDB dayDB = new DayDB { Date= day.Date };
            using(ApplicationDataContext db = new ApplicationDataContext())
            {
                bool isExist = db.Days.Any(x => x.Date == day.Date);
                if (isExist != true)
                {
                    db.Days.Add(dayDB);
                    db.SaveChanges();
                }
            }
            return day;
        }

        public Interval AddInterval(Interval interval)
        {
            IntervalDB intervalDB = new IntervalDB { FirstTimeHour = interval.FirstTimeHour,
                FirstTimeMinute = interval.FirstTimeMinute,
                LastTimeHour = interval.LastTimeHour, 
                LastTimeMinute = interval.LastTimeMinute };
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                bool isExist = db.Intervals.Any(x => x.FirstTimeHour == interval.FirstTimeHour 
                && x.FirstTimeMinute == interval.FirstTimeMinute 
                && x.LastTimeHour == interval.LastTimeHour 
                && x.LastTimeMinute == interval.LastTimeMinute);
                if (isExist != true)
                {
                    db.Intervals.Add(intervalDB);
                    db.SaveChanges();
                }
            }
            return interval;
        }

        public void AddLesson(Lesson lesson)
        {
            DayDB dayDB = new DayDB { Date = lesson.Day.Date };
            RoomDB roomDB = new RoomDB { Number = lesson.Room.Number };
            IntervalDB intervalDB = new IntervalDB
            {
                FirstTimeHour = lesson.Interval.FirstTimeHour,
                FirstTimeMinute = lesson.Interval.FirstTimeMinute,
                LastTimeHour = lesson.Interval.LastTimeHour,
                LastTimeMinute = lesson.Interval.LastTimeMinute
            };
            TeacherDB teacherDB = new TeacherDB { FirstName = lesson.Teacher.FirstName, SecondName = lesson.Teacher.SecondName, Surname = lesson.Teacher.Surname };

            LessonDB lessonDB = new LessonDB
            {
                Name = lesson.Name,
                Task = lesson.Task,
                Progress = lesson.Progress,
                Day = dayDB,
                Interval = intervalDB
            };

            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                bool isExist = db.Lessons.Any(x => x.Name == lesson.Name
                && x.Task == lesson.Task
                && x.Progress == lesson.Progress
                && x.Day == lessonDB.Day
                && x.Interval == lessonDB.Interval
                && x.Teacher == lessonDB.Teacher
                && x.Room == lessonDB.Room);
                if (isExist != true)
                {
                    AddDay(lesson.Day);
                    AddInterval(lesson.Interval);
                    AddRoom(lesson.Room);
                    AddTeacher(lesson.Teacher);
                    db.Lessons.Add(lessonDB);
                    db.SaveChanges();
                }
            }
        }

        public Room AddRoom(Room room)
        {
            RoomDB roomDB = new RoomDB { Number = room.Number };
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                bool isExist = db.Rooms.Any(x => x.Number == room.Number);
                if (isExist != true)
                {
                    db.Rooms.Add(roomDB);
                    db.SaveChanges();
                }
            }
            return room;
        }

        public Teacher AddTeacher(Teacher teacher)
        {
            TeacherDB teacherDB = new TeacherDB { FirstName = teacher.FirstName, SecondName = teacher.SecondName, Surname = teacher.Surname };
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                bool isExist = db.Teachers.Any(x => x.FirstName == teacher.FirstName && x.SecondName == teacher.SecondName && x.Surname == teacher.Surname);
                if (isExist != true)
                {
                    db.Teachers.Add(teacherDB);
                    db.SaveChanges();
                }
            }
            return teacher;
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
