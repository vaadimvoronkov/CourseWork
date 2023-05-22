using CourseWork2.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.Model.Repository
{
    public class Repository
    {
        public ObservableCollection<LessonVM> lessonVMs = new();
        public List<Lesson> lessons = new();
        public List<Day> days = new();
    }
}
