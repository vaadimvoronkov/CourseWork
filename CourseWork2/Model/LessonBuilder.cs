using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Model
{
    public class LessonBuilder
    {
        private Lesson lesson;
        public LessonBuilder()
        {
            lesson = new Lesson();
        }
        public LessonBuilder SetName(string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            lesson.Name = name;
            return this;
        }
        public LessonBuilder SetTask(string task)
        {
            if (task is null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            lesson.Task = task;
            return this;
        }

        public LessonBuilder SetProgress(bool progress)
        {
           lesson.Progress = progress;
            return this;
        }
        public LessonBuilder SetInterval(Interval interval)
        {
            if (interval is null)
            {
                throw new ArgumentNullException(nameof(interval));
            }

            lesson.Interval= interval;
            return this;
        }
        public LessonBuilder SetTeacher(Teacher teacher)
        {
            if (teacher is null)
            {
                throw new ArgumentNullException(nameof(teacher));
            }

            lesson.Teacher = teacher;
            return this;
        }
        public LessonBuilder SetRoom(Room room)
        {
            if (room is null)
            {
                throw new ArgumentNullException(nameof(room));
            }

            lesson.Room = room;
            return this;
        }
        public LessonBuilder SetDay(Day day)
        {
            if (day is null)
            {
                throw new ArgumentNullException(nameof(day));
            }

            lesson.Day = day;
            return this;
        }
        public Lesson Build()
        {
            return lesson;
        }
    }
}
