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
    internal class AddLessonVM : INotifyPropertyChanged // Создать RelayCommand, в котором будет отправляться в репозиторий заполненный  AddLessonView. После чего проверить и сохранить данные в репозиторий
    {
        private Lesson _lesson;

        #region Реализация свойств
        public RelayCommand AddLesson
        {
            get
            {
                return  new RelayCommand(obj =>
                {

                    Lesson lesson = new Lesson(LessonName,LessonTask,false,LessonFirstTime,LessonLastTime,LessonDate);

                });
                  
            }
        }
        public string LessonName
        {
            get 
            { 
                return _lesson.Name;
            }
            set 
            { 
                _lesson.Name = value;
                OnPropertyChanged("LessonName");
            }
        }

        public DateTime LessonDate
        {
            get
            {
                return _lesson.Date;
            }
            set
            {
                _lesson.Date = value;
                OnPropertyChanged("LessonDate");
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
                OnPropertyChanged("LessonTask");
            }
        }

        public int FirstTimeHour
        {
            get
            {
                return FirstTimeHour;
            }
            set 
            {
                FirstTimeHour = value; 
                OnPropertyChanged("FirstTimeHour");
            }
        }

        public int FirstTimeMinute
        {
            get
            {
                return FirstTimeMinute;
            }
            set
            {
                FirstTimeMinute = value; 
                OnPropertyChanged("FirstTimeMinute");
            }
        }
        public int LastTimeHour
        {
            get
            {
                return LastTimeHour;
            }
            set
            {
               LastTimeHour = value;
               OnPropertyChanged("LastTimeHour");
            }
        }

        public int LastTimeMinute
        {
            get
            {
                return LastTimeMinute;
            }
            set
            {
               LastTimeMinute = value;
               OnPropertyChanged("LastTimeMinute");
            }
        }

        public DateTime LessonFirstTime
        {
            get
            {
                return _lesson.FirstTime;
            }
            set
            {
                _lesson.FirstTime = FormTime(FirstTimeHour,FirstTimeMinute);
                OnPropertyChanged("LessonFirstTime");
            }
        }

        public DateTime LessonLastTime
        {
            get
            {
                return _lesson.LastTime;
            }
            set
            {
                _lesson.LastTime = FormTime(LastTimeHour, LastTimeMinute);
                OnPropertyChanged("LessonLastTime");
            }
        }
        #endregion

        private DateTime FormTime(int hours,int minutes)
        {
            return new DateTime(LessonDate.Year, LessonDate.Month, LessonDate.Day, hours, minutes, 0);
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
