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

        #region Реализация свойств LessonVM
        public string LessonName
        {
            get
            {
                return _lesson.LessonName;
            }
            set
            {
                _lesson.LessonName = value;
                OnPropertyChanged("ChangedName");
            }
        }
        public string LessonTask
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
        public string Interval
        {
            get
            {
                return _lesson.FirstTime.ToString() +":"+ _lesson.LastTime.ToString();
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
