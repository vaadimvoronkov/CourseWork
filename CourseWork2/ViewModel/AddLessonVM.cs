using CourseWork2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.ViewModel
{
    internal class AddLessonVM: INotifyPropertyChanged
    {
        private Lesson lesson;

        #region Реализация свойств
        public string LessonName
        {
            get 
            { 
                return lesson.LessonName;
            }
            set 
            { 
                lesson.LessonName = value;
                OnPropertyChanged("LessonName");
            }
        }
        public DateTime Date
        {
            get
            {
                return lesson.Date;
            }
            set
            {
                lesson.Date = value;
                OnPropertyChanged("Date");
            }
        }
        public string Task
        {
            get
            {
                return lesson.Task;
            }
            set
            {
                lesson.Task = value;
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
                return lesson.FirstTime;
            }
            set
            {
                lesson.FirstTime = FormTime(FirstTimeHour,FirstTimeMinute);
                OnPropertyChanged("FirstTime");
            }
        }
        public DateTime LastTime
        {
            get
            {
                return lesson.LastTime;
            }
            set
            {
                lesson.LastTime = FormTime(LastTimeHour, LastTimeMinute);
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
