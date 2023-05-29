using CourseWork2.Model;
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
        private Lesson _lesson;
        public LessonVM(Lesson lesson)
        {
            _lesson = lesson;
        }

        #region Реализация свойств для lesson
        public string Name
        {
            get
            {
                return _lesson.Name;
            }
            set
            {
                _lesson.Name = value;
                OnPropertyChanged("ChangedName");
            }
        }
        public string Task
        {
            get
            {
                return _lesson.Task;
            }
            set
            {
                _lesson.Task = value;
                OnPropertyChanged("ChangedTask");
            }
        }
        public bool Progress
        {
            get
            {
                return _lesson.Progress;
            }
            set
            {
                _lesson.Progress = value;
                OnPropertyChanged("ChangedProgress");
            }
        }
        public string FirstTime
        {
            get
            {
                return _lesson.Interval.FirstTimeHour+":"+_lesson.Interval.FirstTimeMinute.ToString();
            }

        }
        public string LastTime
        {
            get
            {
                return _lesson.Interval.LastTimeHour+ ":" + _lesson.Interval.LastTimeMinute.ToString();
            }
        }
        public int Room
        {
            get
            {
                return _lesson.Room.Number;
            }
            set
            {
                _lesson.Room.Number = value;
                OnPropertyChanged("ChangedRoomNumber");
            }
        }
        public string Teacher
        {
            get
            {
                return _lesson.Teacher.FirstName + " " + _lesson.Teacher.SecondName + " " + _lesson.Teacher.Surname;
            }
        }
        #endregion

        #region Реализация INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
