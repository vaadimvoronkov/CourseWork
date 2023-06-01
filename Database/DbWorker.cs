using Database.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class DbWorker
    {
            public static string CreateLesson(LessonDB lesson) //исправить на && и доабвить методы првоерок
        {
            string result = "Урок с таким наобором данных уже существует!";
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                bool isExist = db.Lessons.
                    Any(x => x.Name == lesson.Name 
                    && x.Interval == lesson.Interval 
                    && lesson.Teacher == lesson.Teacher 
                    && x.Day == lesson.Day 
                    && x.Task == lesson.Task 
                    && x.Room == lesson.Room 
                    && x.Progress == lesson.Progress);

                if (isExist != true)
                {
                    db.Lessons.Add(lesson);
                    db.SaveChanges();
                    result = "Выполнено!";
                }
                return result;
            }
        }
        public static string CreateDay(DayDB day)
        {
            string result = "День с такой датой уже существует!";
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                bool isExist = db.Days.Any(x => x.Date == day.Date);
                if (isExist != true)
                {
                    db.Days.Add(day);
                    db.SaveChanges();
                    result = "Выполнено!";
                }
                return result;
            }
        }
        public static string CreateInterval(IntervalDB interval)
        {
            string result = "Такой интервал уже существует!";
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                bool isExist = db.Intervals.Any(x => x.FirstTimeHour == interval.FirstTimeHour & x.FirstTimeMinute ==interval.FirstTimeMinute & x.LastTimeHour == interval.LastTimeHour & x.LastTimeMinute == interval.LastTimeMinute);
                if (isExist != true)
                {
                    db.Intervals.Add(interval);
                    db.SaveChanges();
                    result = "Выполнено!";
                }
                return result;
            }
        }
        public static string CreateRoom(RoomDB room)
        {
            string result = "Комната с таким номером уже существует!";
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                bool isExist = db.Rooms.Any(x => x.Number == room.Number);
                if (isExist != true)
                {
                    db.Rooms.Add(room);
                    db.SaveChanges();
                    result = "Выполнено!";
                }
                return result;
            }
        }
        public static string CreateTeacher(TeacherDB teacher)
        {
            string result = "Такой учитель уже существует!";
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                bool isExist = db.Teachers.Any(x => x.FirstName == teacher.FirstName & x.SecondName == teacher.SecondName & x.Surname == teacher.Surname);
                if (isExist != true)
                {
                    db.Teachers.Add(teacher);
                    db.SaveChanges();
                    result = "Выполнено!";
                }
                return result;
            }
        }

        //Удаление данных
        public static string DeleteLesson(LessonDB lesson)
        {
            string result = "Такого урока не существует!";
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                db.Lessons.Remove(lesson);
                db.SaveChanges();
                result = "Урок был успешно удалён!";
            }
            return result;
        }
        public static string DeleteDay(DayDB day)
        {
            string result = "Такого дня не существует!";
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                db.Days.Remove(day);
                db.SaveChanges();
                result = "День был успешно удалён!";
            }
            return result;
        }
        public static string DeleteInterval(IntervalDB interval)
        {
            string result = "Такого временного интервала не существует!";
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                db.Intervals.Remove(interval);
                db.SaveChanges();
                result = "Временной интервал был успешно удалён!";
            }
            return result;
        }
        public static string DeleteRoom(RoomDB room)
        {
            string result = "Такого кабинета не существует!";
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                db.Rooms.Remove(room);
                db.SaveChanges();
                result = "Кабинет был успешно удалён!";
            }
            return result;
        }
        public static string DeleteTeacher(TeacherDB teacher)
        {
            string result = "Такого учителя не существует!";
            using (ApplicationDataContext db = new ApplicationDataContext())
            {
                db.Teachers.Remove(teacher);
                db.SaveChanges();
                result = "Учитель был успешно удалён!";
            }
            return result;
        }

        //Получение данных


    }
}
