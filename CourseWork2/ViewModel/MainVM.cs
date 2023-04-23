using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CourseWork2.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private DateTime selectedDate;
        public DateTime SelectedDate
        {
            get
            {
                return selectedDate;
            }
            set
            {
                selectedDate = value;
                OnPropertyChanged("SelectedDate");

            }
        }
        public InformationOnDateVM informationOnDateVM
        {
            get 
            { 
                return informationOnDateVM; 
            }
            set
            {
                informationOnDateVM = value;
                OnPropertyChanged("SelectedInformation");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
