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
    public class LessonsTabVM 
    {
        private ObservableCollection<LessonVM> _lessons;

        public ObservableCollection<LessonVM> Lessons { get => _lessons; }

        #region Реализация методов LessonsTabVM
        public void AddLessonVM(LessonVM lessonVM)
        {
            _lessons.Add(lessonVM);
        }
        public void RemoveLessonVM(LessonVM lessonVM)
        {
            _lessons.Remove(lessonVM);
        }
        public void ClearLessons()
        {
            _lessons.Clear();
        }
        #endregion

    }
}
