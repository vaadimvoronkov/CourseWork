using System.Collections.Generic;
using System.Windows.Documents;

namespace CourseWork2.Model
{
    public interface IRepository
    {
        void AddDay(Day day);
        void AddInterval(Interval interval);
        void AddLesson(Lesson lesson);
        void AddRoom(Room room);
        void AddTeacher(Teacher teacher);
        void RemoveDay(Day day);
        void RemoveInterval(Interval interval);
        void RemoveLesson(Lesson lesson);
        void RemoveRoom(Room room);
        void RemoveTeacher(Teacher teacher);
        List<Lesson> GetLessons();
        List<Day> GetDays();
        List<Room> GetRooms();
        List<Interval> GetIntervals();
        List<Teacher> GetTeachers();
    }
}