using CourseWork2.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Model.RepositoryDB
{
    public static class DbWorker
    {
        //Создание данных
        //    public static string CreateLesson(string name, string task, bool progress, Interval interval, Teacher teacher, Room room, Day day) // Передавать не свойства, а объекты и создавать на основе созданных объектов
        //    {
        //        string result = "Урок с таким наобором данных уже существует!";
        //        using (ApplicationDataContext db = new ApplicationDataContext())
        //        {
        //            bool isExist = db.Lessons.Any(x => x.Name == name && x.Task == task && x.Progress == progress && x.Interval == interval && x.Teacher == teacher && x.Room == room && x.Day == day);
        //            if (isExist != true)
        //            {
        //                Lesson lesson = new Lesson
        //                {
        //                    Name = name,
        //                    Task = task,
        //                    Progress = progress,
        //                    IntervalId = interval.IntervalId,
        //                    Interval = interval,
        //                    TeacherId = teacher.TeacherId,
        //                    Teacher = teacher,
        //                    RoomId = room.RoomId,
        //                    Room = room,
        //                    DayId = day.DayId,
        //                    Day = day
        //                };
        //                db.Lessons.Add(lesson);
        //                db.SaveChanges();
        //                result = "Выполнено!";
        //            }
        //            return result;
        //        }
        //    }
        //    //public static string CreateDay(DateTime date)
        //    //{
        //    //    string result = "День с такой датой уже существует!";
        //    //    using (ApplicationDataContext db = new ApplicationDataContext())
        //    //    {
        //    //        bool isExist = db.Days.Any(x => x.Date == date);
        //    //        if (isExist != true)
        //    //        {
        //    //            Day day = new Day { Date = date };
        //    //            db.Days.Add(day);
        //    //            db.SaveChanges();
        //    //            result = "Выполнено!";
        //    //        }
        //    //        return result;
        //    //    }
        //    //}
        //    public static string CreateInterval(DateTime firstTime, DateTime lastTime)
        //    {
        //        string result = "Такой интервал уже существует!";
        //        using (ApplicationDataContext db = new ApplicationDataContext())
        //        {
        //            bool isExist = db.Intervals.Any(x => x.FirstTime == firstTime & x.LastTime == lastTime);
        //            if (isExist != true)
        //            {
        //                Interval interval = new Interval { FirstTime = firstTime, LastTime = lastTime };
        //                db.Intervals.Add(interval);
        //                db.SaveChanges();
        //                result = "Выполнено!";
        //            }
        //            return result;
        //        }
        //    }
        //    public static string CreateRoom(int roomNumber)
        //    {
        //        string result = "Комната с таким номером уже существует!";
        //        using (ApplicationDataContext db = new ApplicationDataContext())
        //        {
        //            bool isExist = db.Rooms.Any(x => x.Number == roomNumber);
        //            if (isExist != true)
        //            {
        //                Room room = new Room { Number = roomNumber };
        //                db.Rooms.Add(room);
        //                db.SaveChanges();
        //                result = "Выполнено!";
        //            }
        //            return result;
        //        }
        //    }
        //    public static string CreateTeacher(string firstName, string secondName, string surname)
        //    {
        //        string result = "Такой учитель уже существует!";
        //        using (ApplicationDataContext db = new ApplicationDataContext())
        //        {
        //            bool isExist = db.Teachers.Any(x => x.FirstName == firstName & x.SecondName == secondName & x.Surname == surname);
        //            if (isExist != true)
        //            {
        //                Teacher teacher = new Teacher { FirstName = firstName, SecondName = secondName, Surname = surname };
        //                db.Teachers.Add(teacher);
        //                db.SaveChanges();
        //                result = "Выполнено!";
        //            }
        //            return result;
        //        }
        //    }

        //    //Удаление данных
        //    public static string DeleteLesson(Lesson lesson)
        //    {
        //        string result = "Такого урока не существует!";
        //        using (ApplicationDataContext db = new ApplicationDataContext())
        //        {
        //            db.Lessons.Remove(lesson);
        //            db.SaveChanges();
        //            result = "Урок был успешно удалён!";
        //        }
        //        return result;
        //    }
        //    public static string DeleteDay(Day day)
        //    {
        //        string result = "Такого дня не существует!";
        //        using (ApplicationDataContext db = new ApplicationDataContext())
        //        {
        //            db.Days.Remove(day);
        //            db.SaveChanges();
        //            result = "День был успешно удалён!";
        //        }
        //        return result;
        //    }
        //    public static string DeleteInterval(Interval interval)
        //    {
        //        string result = "Такого временного интервала не существует!";
        //        using (ApplicationDataContext db = new ApplicationDataContext())
        //        {
        //            db.Intervals.Remove(interval);
        //            db.SaveChanges();
        //            result = "Временной интервал был успешно удалён!";
        //        }
        //        return result;
        //    }
        //    public static string DeleteRoom(Room room)
        //    {
        //        string result = "Такого кабинета не существует!";
        //        using (ApplicationDataContext db = new ApplicationDataContext())
        //        {
        //            db.Rooms.Remove(room);
        //            db.SaveChanges();
        //            result = "Кабинет был успешно удалён!";
        //        }
        //        return result;
        //    }
        //    public static string DeleteTeacher(Teacher teacher)
        //    {
        //        string result = "Такого учителя не существует!";
        //        using (ApplicationDataContext db = new ApplicationDataContext())
        //        {
        //            db.Teachers.Remove(teacher);
        //            db.SaveChanges();
        //            result = "Учитель был успешно удалён!";
        //        }
        //        return result;
        //    }

        //    //Получение данных

        //
    }
}
