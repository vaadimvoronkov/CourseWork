using CourseWork2.Commands;
using CourseWork2.Model;
using CourseWork2.Model.Repository;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CourseWork2.ViewModel
{
    public class AddLessonVM : INotifyPropertyChanged // Создать RelayCommand, в котором будет отправляться в репозиторий заполненный  AddLessonView. После чего проверить и сохранить данные в репозиторий
    {
        private Lesson _lesson;
        private Repository repository;
        public AddLessonVM(Repository repository)
        {
            this.repository = repository;
        }
       
        #region Реализация свойств
        public RelayCommand AddLesson 
        {
            get
            {
                return  new RelayCommand(obj =>
                {

                    _lesson = new(LessonName,LessonTask,false,new Interval(FirstTime,LastTime),LessonDay);


                });
                  
            }
        }
        public RelayCommand SaveLesson
        {
            get
            {
                return new RelayCommand(obj =>
                {

                    repository.lessons.Add(_lesson);

                });

            }
        }
        public string LessonName
        {
            get 
            { 
                return _lesson.Name;
            }
            set 
            { 
                _lesson.Name = value;
                OnPropertyChanged("LessonName");
            }
        }

        public Day LessonDay
        {
            get
            {
                return _lesson.Day;
            }
            set
            {
                _lesson.Day = value;
                OnPropertyChanged("LessonDay");
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
                OnPropertyChanged("LessonTask");
            }
        }

        public int FirstTimeHour
        {
            get
            {
                return FirstTimeHour;
            }
            set 
            {
                FirstTimeHour = value; 
                OnPropertyChanged("LessonFirstTimeHour");
            }
        }

        public int FirstTimeMinute
        {
            get
            {
                return FirstTimeMinute;
            }
            set
            {
                FirstTimeMinute = value; 
                OnPropertyChanged("LessonFirstTimeMinute");
            }
        }
        public int LastTimeHour
        {
            get
            {
                return LastTimeHour;
            }
            set
            {
               LastTimeHour = value;
               OnPropertyChanged("LessonLastTimeHour");
            }
        }

        public int LastTimeMinute
        {
            get
            {
                return LastTimeMinute;
            }
            set
            {
               LastTimeMinute = value;
               OnPropertyChanged("LessonLastTimeMinute");
            }
        }

        public DateTime FirstTime
        {
            get
            {
                return _lesson.Interval.FirstTime;
            }
            set
            {
                _lesson.Interval.FirstTime = FormTime(FirstTimeHour,FirstTimeMinute);
                OnPropertyChanged("LessonFirstTime");
            }
        }

        public DateTime LastTime
        {
            get
            {
                return _lesson.Interval.LastTime;
            }
            set
            {
                _lesson.Interval.LastTime = FormTime(LastTimeHour, LastTimeMinute);
                OnPropertyChanged("LessonLastTime");
            }
        }
        public int RoomNumber
        {
            get
            {
                return _lesson.Room.Number;
            }
            set
            {
                _lesson.Room.Number = value;
                OnPropertyChanged("LessonRoomNumber");
            }
        }
        public string TeacherFirstName
        {
            get
            {
                return _lesson.Teacher.FirstName;
            }
            set
            {
                _lesson.Teacher.FirstName = value;
                OnPropertyChanged("LessonTeacherFirstName");
            }
        }
        public string TeacherSecondName
        {
            get
            {
                return _lesson.Teacher.SecondName;
            }
            set
            {
                _lesson.Teacher.SecondName = value;
                OnPropertyChanged("LessonTeacherSecondName");
            }
        }
        public string TeacherSurname
        {
            get
            {
                return _lesson.Teacher.Surname;
            }
            set
            {
                _lesson.Teacher.Surname = value;
                OnPropertyChanged("LessonTeacherSurname");
            }
        }
        #endregion

        private DateTime FormTime(int hours,int minutes)
        {
            return new DateTime(LessonDay.Date.Year, LessonDay.Date.Month, LessonDay.Date.Day, hours, minutes, 0);
        }

        #region Реализация INotifyProperyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
