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

        #endregion

        #region Методы получения данных
        public Teacher GetTeacher(Teacher teacher)
        {
            if (teachers.Contains(teachers.SingleOrDefault(x => x.FirstName == teacher.FirstName 
            && x.SecondName == teacher.SecondName 
            && x.Surname == teacher.Surname)))
            {
                return teachers.Single(x => x.FirstName == teacher.FirstName
                && x.SecondName == teacher.SecondName 
                && x.Surname == teacher.Surname);
            }
            else
            {
                teachers.Add(new Teacher(teacher.FirstName, teacher.SecondName, teacher.Surname));
                return teachers.Single(x => x.FirstName == teacher.FirstName 
                && x.SecondName == teacher.SecondName 
                && x.Surname == teacher.Surname);
            }
        }
        public Day GetDay(Day day)
        {
            if (days.Contains(days.SingleOrDefault(x => x.Date == day.Date)))
            {
                return days.Single(x => x.Date == day.Date);
            }
            else
            {
                days.Add(new Day(day.Date));
                return days.Single(x => x.Date == day.Date);
            }
        }

        public Interval GetInterval(Interval interval)
        {
            if (intervals.Contains(intervals.SingleOrDefault(x => x.FirstTimeHour == interval.FirstTimeHour 
            && x.FirstTimeMinute == interval.FirstTimeMinute 
            && x.LastTimeHour == interval.LastTimeHour 
            && x.LastTimeMinute== interval.LastTimeMinute)))
            {
                return intervals.Single(x => x.FirstTimeHour == interval.FirstTimeHour 
                && x.FirstTimeMinute == interval.FirstTimeMinute 
                && x.LastTimeHour == interval.LastTimeHour 
                && x.LastTimeMinute == interval.LastTimeMinute);
            }
            else
            {
                intervals.Add(new Interval(interval.FirstTimeHour,interval.FirstTimeMinute,interval.LastTimeHour,interval.LastTimeMinute));
                return intervals.Single(x => x.FirstTimeHour == interval.FirstTimeHour 
                && x.FirstTimeMinute == interval.FirstTimeMinute 
                && x.LastTimeHour == interval.LastTimeHour 
                && x.LastTimeMinute == interval.LastTimeMinute);
            }
        }

        public Room GetRoom(Room room)
        {
            if (rooms.Contains(rooms.SingleOrDefault(x => x.Number == room.Number)))
            {
                return rooms.Single( x => x.Number == room.Number);
            }
            else
            {
                rooms.Add(new Room(room.Number));
                return rooms.Single(x => x.Number == room.Number);
            }
        }

        public List<Lesson> GetLessons()
        {
            return lessons;
        }
        #endregion
    }
}
