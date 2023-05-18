using CourseWork2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.ViewModel
{
    public class LessonsTabVM // Добавить конструктор, который принимает дату, после чего можно создать метод LoadDate
    {
        private ObservableCollection<LessonVM> _lessons = new();
        public LessonsTabVM(DateTime dateTime)
        {
            LoadDate(dateTime);
        }
        public ObservableCollection<LessonVM> Lessons { get => _lessons; }
        private void LoadDate(DateTime dateTime)
        {
            //var loadedlessons = Lessons.Where(lessonVM => lessonVM.Date == dateTime);
        }

    }
}
