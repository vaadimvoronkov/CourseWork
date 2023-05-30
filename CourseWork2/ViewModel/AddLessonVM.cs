using CourseWork2.Commands;
using CourseWork2.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace CourseWork2.ViewModel
{
    public class AddLessonVM : INotifyPropertyChanged 
    {
        private Lesson _lesson;
        private Repository repository;
        private string _lessonName;
        private DateTime _dayDate = DateTime.Today;
        private string _lessonTask;
        private int _firstTimeHour;
        private int _firstTimeMinute;
        private int _lastTimeHour;
        private int _lastTimeMinute;
        private int _roomNumber;
        private string _teacherFirstName;
        private string _teacherSecondName;
        private string _teacherSurname;

        public AddLessonVM(Repository repository)
        {
            this.repository = repository;
        }

        #region Реализация привязки комманд
        public RelayCommand AddLesson  
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    try
                    {
                        _lesson = new(_lessonName, _lessonTask, false, new Interval(FirstTimeHour, FirstTimeMinute, LastTimeHour, LastTimeMinute), new Day(DayDate), new Teacher(TeacherFirstName, TeacherSecondName, TeacherSurname), new Room(RoomNumber));
                        repository.AddLesson(_lesson);
                    }
                    catch (ArgumentNullException ex) 
                    {
                        MessageBox.Show(ex.Message);
                    }

                });

            }
        }
        #endregion

        #region Реализация свойств
        public string LessonName
        {
            get
            {
                return _lessonName;
            }
            set
            {
                _lessonName = value;
                OnPropertyChanged("LessonName");
            }
        }
        public DateTime DayDate
        {
            get
            {
                return _dayDate;
            }
            set
            {
                _dayDate = value;
                OnPropertyChanged("DayDate");
            }
        }
        public string LessonTask
        {
            get
            {
                return _lessonTask;
            }
            set
            {
                _lessonTask = value;
                OnPropertyChanged("LessonTask");
            }
        }
        public int FirstTimeHour
        {
            get
            {
                return _firstTimeHour;
            }
            set
            {
                if(value>=0 && value<24)
                {
                    _firstTimeHour = value;
                    OnPropertyChanged("FirstTimeHour");
                }
            }
        }
        public int FirstTimeMinute
        {
            get
            {
                return _firstTimeMinute;
            }
            set
            {
                _firstTimeMinute = value;
                OnPropertyChanged("FirstTimeMinute");
            }
        }
        public int LastTimeHour
        {
            get
            {
                return _lastTimeHour;
            }
            set
            {
                if (value >= 0 && value < 24)
                {
                    _lastTimeHour = value;
                    OnPropertyChanged("LastTimeHour");
                }
            }
        }
        public int LastTimeMinute
        {
            get
            {
                return _lastTimeMinute;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    _lastTimeMinute = value;
                    OnPropertyChanged("LastTimeMinute");
                }
            }
        }

        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                _roomNumber = value;
                OnPropertyChanged("RoomNumber");
            }
        }
        public string TeacherFirstName
        {
            get
            {
                return _teacherFirstName;
            }
            set
            {
                _teacherFirstName = value;
                OnPropertyChanged("TeacherFirstName");
            }
        }
        public string TeacherSecondName
        {
            get
            {
                return _teacherSecondName;
            }
            set
            {
               _teacherSecondName = value;
                OnPropertyChanged("TeacherSecondName");
            }
        }
        public string TeacherSurname
        {
            get
            {
                return _teacherSurname;
            }
            set
            {
                _teacherSurname= value;
                OnPropertyChanged("TeacherSurname");
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
