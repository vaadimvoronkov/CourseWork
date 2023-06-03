﻿using System;
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