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

namespace WpfApp7.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage18.xaml
    /// </summary>
    public partial class TaskPage18 : Page
    {
        public TaskPage18()
        {
            InitializeComponent();
            bool A = true, B = false, C = false;

            MessageBox.Show($"18){A&&!B||C}\n2{A && (!B||C)}\n3{A||(!(B&&C))}",
                         "Task #18",
                         MessageBoxButton.OK,
                         MessageBoxImage.Question);
        }
    }
    
}
