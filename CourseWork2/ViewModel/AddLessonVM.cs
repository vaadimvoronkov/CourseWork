﻿using CourseWork2.Commands;
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

                    Lesson lesson = new(LessonName,LessonTask,false,LessonFirstTime,LessonLastTime,LessonDay);
                    repository.lessons.Add(lesson);

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
                OnPropertyChanged("FirstTimeHour");
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
                OnPropertyChanged("FirstTimeMinute");
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
               OnPropertyChanged("LastTimeHour");
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
               OnPropertyChanged("LastTimeMinute");
            }
        }

        public DateTime LessonFirstTime
        {
            get
            {
                return _lesson.FirstTime;
            }
            set
            {
                _lesson.FirstTime = FormTime(FirstTimeHour,FirstTimeMinute);
                OnPropertyChanged("LessonFirstTime");
            }
        }

        public DateTime LessonLastTime
        {
            get
            {
                return _lesson.LastTime;
            }
            set
            {
                _lesson.LastTime = FormTime(LastTimeHour, LastTimeMinute);
                OnPropertyChanged("LessonLastTime");
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
