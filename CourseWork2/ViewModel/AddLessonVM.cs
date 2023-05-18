using CourseWork2.Commands;
using CourseWork2.Model;
using CourseWork2.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CourseWork2.ViewModel
{
    internal class AddLessonVM : INotifyPropertyChanged //сделать propertychanged, сделать привязку комманд на кнопку. Создать RelayCommand, в котором будет отправляться в репозиторий заполненный  AddLessonView. После чего проверить и сохранить данные в репозиторий
    {
        private Lesson _lesson;

        #region Реализация свойств
        public RelayCommand AddLesson
        {
            get
            {
                return  new RelayCommand(obj =>
                {
                    
                });
                  
            }
        }
        public string LessonName
        {
            get 
            { 
                return _lesson.LessonName;
            }
            set 
            { 
                _lesson.LessonName = value;
                OnPropertyChanged("LessonName");
            }
        }

        public DateTime Date
        {
            get
            {
                return _lesson.Date;
            }
            set
            {
                _lesson.Date = value;
                OnPropertyChanged("Date");
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
                OnPropertyChanged("Task");
            }
        }

        public int FirstTimeHour { get; set; }
        public int FirstTimeMinute { get; set; }
        public int LastTimeHour { get; set; }
        public int LastTimeMinute { get; set; }

        public DateTime FirstTime
        {
            get
            {
                return _lesson.FirstTime;
            }
            set
            {
                _lesson.FirstTime = FormTime(FirstTimeHour,FirstTimeMinute);
                OnPropertyChanged("FirstTime");
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
                _lesson.LastTime = FormTime(LastTimeHour, LastTimeMinute);
                OnPropertyChanged("LastTime");
            }
        }
        #endregion

        private DateTime FormTime(int hours,int minutes)
        {
            return new DateTime(Date.Year, Date.Month, Date.Day, hours, minutes, 0);
        }

        #region Реализация INotifyProperyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
