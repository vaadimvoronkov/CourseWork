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

        private List<Lesson> _lessons;
        private List<Day> days;
        private ObservableCollection<LessonVM> lessonVMs;
        private LessonsTabVM tabVM;
        public void AddLesson(Lesson lesson)
        {
            _lessons.Add(lesson);
        }

        public void RemoveLesson(Lesson lesson)
        {
            _lessons.Remove(lesson);
        }


    }
}
