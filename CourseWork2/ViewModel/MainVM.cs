using CourseWork2.Model;
using CourseWork2.Model.Repository;
using CourseWork2.View;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows;

namespace CourseWork2.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private DateTime _selectedDate;
        private LessonsTabVM _lessonsTabVM;
        private Repository repository;
        public MainVM(Repository repository)
        {
            this.repository = repository;
            SelectedDate = DateTime.Now;
        }

        #region Реализация свойств 
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
                return _lessonsTabVM;
            }
            set
            {
                _lessonsTabVM = value;
                OnPropertyChanged("LessonsTab");
            }
        }
        #endregion

        private void UpdateLessons()
        {
           LessonsTabVM lessonsTabVM = new LessonsTabVM(SelectedDate, repository);
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
