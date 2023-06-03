using CourseWork2.Commands;
using CourseWork2.Exceptions;
using CourseWork2.Model;
using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace CourseWork2.ViewModel
{
    public class AddLessonVM : INotifyPropertyChanged 
    {
        private Lesson _lesson;
        private Interval _interval;
        private Teacher _teacher;
        private Day _day;
        private Room _room;
        private IRepository repository;
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

        public AddLessonVM(IRepository repository)
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
                        _day = new(DayDate);
                        _room = new(RoomNumber);
                        _interval = new(FirstTimeHour, FirstTimeMinute, LastTimeHour, LastTimeMinute);
                        _teacher = new(TeacherFirstName, TeacherSecondName, TeacherSurname);

                         _lesson =  Lesson.CreateBuilder()
                        .SetName(LessonName)
                        .SetTask(LessonTask)
                        .SetProgress(false)
                        .SetInterval(repository.GetInterval(_interval))
                        .SetDay(repository.GetDay(_day))
                        .SetTeacher(repository.GetTeacher(_teacher))
                        .SetRoom(repository.GetRoom(_room))
                        .Build();

                        ValidateNumbers(FirstTimeHour, FirstTimeMinute, LastTimeHour, LastTimeMinute,RoomNumber);
                        ValidateTexts(LessonName, LessonTask, TeacherFirstName, TeacherSecondName, TeacherSurname);

                        repository.AddLesson(_lesson);
                    }
                    catch (ArgumentNullException) 
                    {
                        MessageBox.Show("One of the textbox was not filled!");
                    }
                    catch(UncorrectInputStringException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (UncorrectInputIntervalHours ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch(UncorrectRoomNumberException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch(UncorrectHourRangeException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch(UncorrectMinuteRangeException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch(AreEqualTimesException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                });

            }
        }
        #endregion

        #region Реализация валидации данных

        private void ValidateTexts(string lessonName, string lessonTask, string teacherFirstName, string teacherSecondName, string teacherSurname)
        {
            CheckCorrectString(lessonName);
            CheckCorrectString(lessonTask);
            CheckCorrectString(teacherFirstName);
            CheckCorrectString(teacherSecondName);
            CheckCorrectString(teacherSurname);
        }
        private void ValidateNumbers(int firstTimeHour, int firstTimeMinute, int lastTimeHour, int lastTimeMinute, int number)
        {
            CheckCorrectHourRange(firstTimeHour);
            CheckCorrectHourRange(lastTimeHour);
            CheckCorrectMinuteRange(firstTimeMinute);
            CheckCorrectMinuteRange(lastTimeMinute);
            CheckCorrectInterval(firstTimeHour, lastTimeHour);
            CheckNotEqualTimes(firstTimeHour, firstTimeMinute, lastTimeHour, lastTimeMinute);
            CheckCorrectRoomNumber(number);
        }
        private void CheckCorrectString(string stringVariable)
        {
            if (string.IsNullOrEmpty(stringVariable))
            {
                throw new UncorrectInputStringException("One of the textbox was not filled!");
            }
        }
        private void CheckCorrectInterval(int firstTimeHour,int lastTimeHour)
        {
            if (firstTimeHour > lastTimeHour)
            {
                throw new UncorrectInputIntervalHours("The last hour cannot be greater than the start hour.");
            }
        }
        public void CheckNotEqualTimes(int firstTimeHour, int firstTimeMinute, int lastTimeHour, int lastTimeMinute)
        {
            if(firstTimeHour == lastTimeHour && firstTimeMinute == lastTimeMinute)
            {
                throw new AreEqualTimesException("The first and last times are the same!");
            }
        }
        private void CheckCorrectHourRange(int hour)
        {
            if(hour<0 || hour > 23)
            {
                throw new UncorrectHourRangeException("The hour can range from 0 to 23!");
            }
        }
        private void CheckCorrectMinuteRange(int minute)
        {
            if (minute <0 || minute >= 60)
            {
                throw new UncorrectMinuteRangeException("The minute can range from 0 to 59!");
            }
        }
        private void CheckCorrectRoomNumber(int number)
        {
            if (number < 0 || number > 600)
            {
                throw new UncorrectRoomNumberException("Room number cannot be more than 600!");
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

                 _firstTimeHour = value;
                 OnPropertyChanged("FirstTimeHour");

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
                 _lastTimeHour = value;
                 OnPropertyChanged("LastTimeHour");
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
                 _lastTimeMinute = value;
                 OnPropertyChanged("LastTimeMinute");
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
