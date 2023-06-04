using CourseWork2.ViewModel;
using System.Windows;
using System.Data;
using Models;
using Database;

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
            IRepository repository = Repository.GetInstance();
            DataContext  = new MainVM(repository);
        }
    }
}
