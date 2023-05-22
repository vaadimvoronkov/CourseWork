using CourseWork2.Model;
using CourseWork2.Model.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.ViewModel
{
    public class LessonsTabVM // Добавить конструктор, который принимает дату, после чего можно создать метод LoadDate, который берет данные из репозитория
    {
        private ObservableCollection<LessonVM> _lessons = new();
        private Repository repository;
        public ObservableCollection<LessonVM> Lessons { get => _lessons; }
        
        public LessonsTabVM(Repository repository) 
        {
            this.repository = repository;
        }

        public LessonsTabVM(DateTime dateTime)
        {
            //LoadDate(dateTime);
        }
        private void LoadDate(DateTime dateTime)
        {
            //var loadedlessons = Lessons.Where(lessonVM => lessonVM.Date == dateTime);
        }

    }
}
