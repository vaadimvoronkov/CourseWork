using CourseWork2.Commands;
using Models;
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
        private AddLessonVM _addLessonVM;
        private readonly IRepository _repository;

        public MainVM(IRepository repository)
        {
            _repository = repository;
            _addLessonVM = new AddLessonVM(repository);
            SelectedDate = DateTime.Now;
        }

        public DateTime SelectedDate
        {
            get => _selectedDate;
            set
            {
                if (_selectedDate != value)
                {
                    _selectedDate = value;
                    OnPropertyChanged(nameof(SelectedDate));
                    UpdateLessons();
                }
            }
        }

        public LessonsTabVM LessonsTab
        {
            get => _lessonsTabVM;
            set
            {
                if (_lessonsTabVM != value)
                {
                    _lessonsTabVM = value;
                    OnPropertyChanged(nameof(LessonsTab));
                }
            }
        }

        public AddLessonVM AddLessonVM
        {
            get => _addLessonVM;
            set
            {
                if (_addLessonVM != value)
                {
                    _addLessonVM = value;
                    OnPropertyChanged(nameof(AddLessonVM));
                }
            }
        }

        private void UpdateLessons()
        {
            LessonsTabVM lessonsTabVM = new LessonsTabVM(_repository, SelectedDate);
            LessonsTab = lessonsTabVM;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
