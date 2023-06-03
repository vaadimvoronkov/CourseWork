using Database.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class LessonBuilderDB
    {
        private LessonDB lesson;
        public LessonBuilderDB()
        {
            lesson = new LessonDB();
        }
        public LessonBuilderDB SetName(string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            lesson.Name = name;
            return this;
        }
        public LessonBuilderDB SetTask(string task)
        {
            if (task is null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            lesson.Task = task;
            return this;
        }

        public LessonBuilderDB SetProgress(bool progress)
        {
           lesson.Progress = progress;
            return this;
        }
        public LessonBuilderDB SetInterval(IntervalDB interval)
        {
            if (interval is null)
            {
                throw new ArgumentNullException(nameof(interval));
            }

            lesson.Interval= interval;
            return this;
        }
        public LessonBuilderDB SetTeacher(TeacherDB teacher)
        {
            if (teacher is null)
            {
                throw new ArgumentNullException(nameof(teacher));
            }

            lesson.Teacher = teacher;
            return this;
        }
        public LessonBuilderDB SetRoom(RoomDB room)
        {
            if (room is null)
            {
                throw new ArgumentNullException(nameof(room));
            }

            lesson.Room = room;
            return this;
        }
        public LessonBuilderDB SetDay(DayDB day)
        {
            if (day is null)
            {
                throw new ArgumentNullException(nameof(day));
            }

            lesson.Day = day;
            return this;
        }
        public LessonDB Build()
        {
            return lesson;
        }
    }
}
