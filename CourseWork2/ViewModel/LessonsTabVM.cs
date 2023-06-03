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
        private ObservableCollection<LessonVM> _lessons = new();
        private IRepository repository;
        public ObservableCollection<LessonVM> Lessons { get => _lessons; }

        public LessonsTabVM(IRepository repository, DateTime dateTime)
        {
            this.repository = repository;
            LoadDate(dateTime);
        }

        #region Реализация методов
        private void LoadDate(DateTime dateTime) 
        {
            if(repository.GetLessons() != null)
            {
                var loadedlessons = repository.GetLessons().Where(lesson => lesson.Day.Date == dateTime).Select(x=>new LessonVM(x));
                _lessons = new ObservableCollection<LessonVM>(loadedlessons);
            }
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
