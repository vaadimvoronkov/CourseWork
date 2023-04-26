using CourseWork2.ViewModel;
using System.Windows;
using System.Data;


namespace CourseWork2.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext  = new MainVM();
        }
    }
}
