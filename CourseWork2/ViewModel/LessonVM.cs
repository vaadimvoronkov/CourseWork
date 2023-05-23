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
        public DateTime FirstTime
        {
            get
            {
                return _lesson.FirstTime;
            }
            set 
            {
                _lesson.FirstTime = value;
                OnPropertyChanged("ChangedFirstTime");
            }
        }
        public DateTime LastTime
        {
            get
            {
                return _lesson.LastTime;
            }
            set
            {
                _lesson.LastTime = value;
                OnPropertyChanged("ChangedLastTime");
            }
        }
        public DateTime Date { get => _lesson.Day.Date; }
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
