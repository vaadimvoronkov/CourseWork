using CourseWork2.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace CourseWork2.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private DateTime _selectedDate;
        private LessonsTabVM _lessons;

        public DateTime SelectedDate
        {
            get
            {
                return _selectedDate;
            }
            set
            {
                _selectedDate = value;
                OnPropertyChanged("SelectedDate");
                UpdateLessons();
            }
        }
        public LessonsTabVM LessonsTab
        {
            get
            {
                return _lessons;
            }
            set
            {
                _lessons = value;
                OnPropertyChanged("LessonsTab");
            }
        }
        public MainVM()
        {
            SelectedDate = DateTime.Now;
            LessonsTab = new LessonsTabVM();
            Lesson lesson = new Lesson("fds","fds",false,DateTime.Today,DateTime.Today,DateTime.Today);
        }
        private void UpdateLessons()
        {
            var lessonsTabVM = new LessonsTabVM();

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
