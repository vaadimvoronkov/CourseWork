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

        #region Реализация свойств MainVM
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
        public LessonsTabVM Lessons
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
        #endregion

        #region Методы MainVM
        public MainVM()
        {
            SelectedDate = DateTime.Now;
        }
        private void UpdateLessons()
        {
             var updatedLessons = new LessonsTabVM();
        }
        #endregion

        #region Реализация INotifyProperyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
