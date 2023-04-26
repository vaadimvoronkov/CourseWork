using CourseWork2.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace CourseWork2.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private DateTime _selectedDate;
        private ObservableCollection <Lesson> _lessons;

        public DateTime SelectedDate
        {
            get
            {
                return _selectedDate;
            }
            set
            {
                _selectedDate = value;
                OnPropertyChanged("SelectedDate");

            }
        }
        public ObservableCollection<Lesson> Lessons
        {
            get
            {
                return _lessons;
            }
            set
            {
                _lessons = value;
                OnPropertyChanged("Lessons");
            }
        }

        public MainVM() 
        {
             SelectedDate= DateTime.Now;
            _lessons = new ObservableCollection<Lesson>()
            {
                new Lesson("Name", "Task", new TimeInterval(new DateTime(2022,01,01),new DateTime(2022,01,02)),false),
                new Lesson("Name", "Task", new TimeInterval(new DateTime(2022,01,01),new DateTime(2022,01,02)),false),
                new Lesson("Name", "Task", new TimeInterval(new DateTime(2022,01,01),new DateTime(2022,01,02)),false),
                new Lesson("Name", "Task", new TimeInterval(new DateTime(2022,01,01),new DateTime(2022,01,02)),false),

            };
        }

        private void UpdateLessons()
        {
            _lessons.Clear(); // После отчистки необходимо заполнить новыми уроками таблицу ?
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
