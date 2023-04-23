using CourseWork2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2.ViewModel
{
    public class InformationOnDateVM: INotifyPropertyChanged
    {
        private Lesson _lesson;
        public string LessonName
        {
            get
            {
                return _lesson.LessonName;
            }
            set
            {
                _lesson.LessonName = value;
                OnPropertyChanged("ChangedName");
            }
        }
        public string LessonTask
        {
            get
            {
                return _lesson.Task;
            }
            set
            {
                _lesson.Task = value;
                OnPropertyChanged("ChangedTask");
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
