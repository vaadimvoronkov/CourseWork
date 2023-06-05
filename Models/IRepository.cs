using System;
using System.Collections.Generic;

namespace Models
{
    public interface IRepository
    {
        Day AddDay(Day day);
        Interval AddInterval(Interval interval);
        Task AddLesson(Lesson lesson);
        Room AddRoom(Room room);
        Teacher AddTeacher(Teacher teacher);

        void RemoveLesson(Lesson lesson);

        Teacher GetTeacher(Teacher teacher);
        Day GetDay(Day day);
        Interval GetInterval(Interval interval);
        Room GetRoom(Room room);

        List<Lesson> GetLessons();
        List<Interval> GetIntervals();
        List<Room> GetRooms();
        List<Teacher> GetTeachers();
        List<Day> GetDays();
    }
}