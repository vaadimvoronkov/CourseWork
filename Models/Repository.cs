using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
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
        public async Task AddLesson(Lesson lesson)
        {
            await Task.Run(() => lessons.Add(lesson));
        }
        public Day AddDay(Day day)
        {
            days.Add(day);
            return day;
        }
        public Room AddRoom(Room room)
        {
            rooms.Add(room);
            return room;
        }
        public Interval AddInterval(Interval interval)
        {
            intervals.Add(interval);
            return interval;
        }
        public Teacher AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
            return teacher;
        }

        #endregion

        #region Методы удаления данных
        public void RemoveLesson(Lesson lesson)
        {
            lessons.Remove(lesson);
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

        public List<Interval> GetIntervals()
        {
            return intervals;
        }

        public List<Room> GetRooms()
        {
            return rooms;
        }

        public List<Teacher> GetTeachers()
        {
            return teachers;
        }

        public List<Day> GetDays()
        {
            return days;
        }
        #endregion
    }
}
