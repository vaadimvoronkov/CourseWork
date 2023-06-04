using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.ViewModel
{
    public class LessonVM: INotifyPropertyChanged 
    {
        private readonly Lesson _lesson;

        public LessonVM(Lesson lesson)
        {
            _lesson = lesson;
        }

        #region Реализация свойств для lesson

        public string Name
        {
            get => _lesson.Name;
            set
            {
                _lesson.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Task
        {
            get => _lesson.Task;
            set
            {
                _lesson.Task = value;
                OnPropertyChanged(nameof(Task));
            }
        }

        public bool Progress
        {
            get => _lesson.Progress;
            set
            {
                _lesson.Progress = value;
                OnPropertyChanged(nameof(Progress));
            }
        }

        public string FirstTime => FormateTime(_lesson.Interval.FirstTimeHour) + ":" + FormateTime(_lesson.Interval.FirstTimeMinute);

        public string LastTime => FormateTime(_lesson.Interval.LastTimeHour) + ":" + FormateTime(_lesson.Interval.LastTimeMinute);

        public int Room
        {
            get => _lesson.Room.Number;
            set
            {
                _lesson.Room.Number = value;
                OnPropertyChanged(nameof(Room));
            }
        }

        public string Teacher => $"{_lesson.Teacher.FirstName} {_lesson.Teacher.SecondName} {_lesson.Teacher.Surname}";

        #endregion

        public string FormateTime(int number)
        {
            return number >= 0 && number < 10 ? "0" + number.ToString() : number.ToString();
        }

        #region Реализация INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
