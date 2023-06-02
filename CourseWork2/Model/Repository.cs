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
        public Teacher GetTeacher(string firstName, string secondName, string surname)
        {
            if (teachers.Contains(teachers.SingleOrDefault(x => x.FirstName == firstName && x.SecondName == secondName && x.Surname == surname)))
            {
                return teachers.Single(x => x.FirstName == firstName && x.SecondName == secondName && x.Surname == surname);
            }
            else
            {
                teachers.Add(new Teacher(firstName, secondName, surname));
                return teachers.Single(x => x.FirstName == firstName && x.SecondName == secondName && x.Surname == surname);
            }
        }
        public Day GetDay(DateTime date)
        {
            if (days.Contains(days.SingleOrDefault(x => x.Date == date)))
            {
                return days.Single(x => x.Date == date);
            }
            else
            {
                days.Add(new Day(date));
                return days.Single(x => x.Date == date);
            }
        }

        public Interval GetInterval(int firstTimeHour, int firstTimeMinute, int lastTimeHour, int lastTimeMinute)
        {
            if (intervals.Contains(intervals.SingleOrDefault(x => x.FirstTimeHour == firstTimeHour && x.FirstTimeMinute == firstTimeMinute && x.LastTimeHour == lastTimeHour && x.LastTimeMinute==lastTimeMinute)))
            {
                return intervals.Single(x => x.FirstTimeHour == firstTimeHour && x.FirstTimeMinute == firstTimeMinute && x.LastTimeHour == lastTimeHour && x.LastTimeMinute == lastTimeMinute);
            }
            else
            {
                intervals.Add(new Interval(firstTimeHour,firstTimeMinute,lastTimeHour,lastTimeMinute));
                return intervals.Single(x => x.FirstTimeHour == firstTimeHour && x.FirstTimeMinute == firstTimeMinute && x.LastTimeHour == lastTimeHour && x.LastTimeMinute == lastTimeMinute);
            }
        }

        public Room GetRoom(int number)
        {
            if (rooms.Contains(rooms.SingleOrDefault(x => x.Number == number)))
            {
                return rooms.Single( x => x.Number == number);
            }
            else
            {
                rooms.Add(new Room(number));
                return rooms.Single(x => x.Number == number);
            }
        }

        public List<Lesson> GetLessons()
        {
            return lessons;
        }
        #endregion
    }
}
