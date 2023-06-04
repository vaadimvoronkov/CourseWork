using CourseWork2.Commands;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.ViewModel
{
    public class LessonsTabVM
    {
        private ObservableCollection<LessonVM> _lessons;
        private readonly IRepository _repository;
        public LessonsTabVM(IRepository repository, DateTime dateTime)
        {
            _repository = repository;
            LoadDate(dateTime);
        }
        public ObservableCollection<LessonVM> Lessons
        {
            get => _lessons;
            set
            {
                _lessons = value;
                OnPropertyChanged();
            }
        }

        #region Реализация методов

        private void LoadDate(DateTime dateTime)
        {
            var loadedlessons = _repository.GetLessons()?.Where(lesson => lesson.Day.Date == dateTime)?.Select(x => new LessonVM(x));
            Lessons = new ObservableCollection<LessonVM>(loadedlessons ?? Enumerable.Empty<LessonVM>());
        }

        #endregion

        #region Реализация INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
