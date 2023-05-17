using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseWork2.View
{
    /// <summary>
    /// Логика взаимодействия для AddLessonView.xaml
    /// </summary>
    public partial class AddLessonView : UserControl // создать новый viewmodel. добавить кнопку сохранить. перед отправкой вьюмодела убедиться, что все данные введены, после чего отправить в модель
    {
        public AddLessonView()
        {
            InitializeComponent();
        }
    }
}
