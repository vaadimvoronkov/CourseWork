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
            IRepository repository = Repository.GetInstance();
            //IRepository repository = new DbRepository();
            DataContext  = new MainVM(repository);
        }
    }
}
