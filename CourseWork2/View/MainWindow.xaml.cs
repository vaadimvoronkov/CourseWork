using CourseWork2.ViewModel;
using System.Windows;
using System.Data;
using CourseWork2.Model.Repository;

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
            Repository repository = Repository.GetInstance();
            DataContext  = new MainVM(repository);
        }
    }
}
