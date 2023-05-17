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
        private DateTime dateTime;
        public LessonsTabVM(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }
        public ObservableCollection<LessonVM> Lessons { get => _lessons; }
        private void LoadDate()
        {

        }

        
 
    }
}
