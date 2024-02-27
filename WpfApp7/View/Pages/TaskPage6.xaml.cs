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
    /// Логика взаимодействия для TaskPage6.xaml
    /// </summary>
    public partial class TaskPage6 : Page
    {
        public TaskPage6()
        {
            InitializeComponent();
            bool x = false, y = false, z = true;
            MessageBox.Show($"6){x || y && !z}\n2{!z && !y}\n3 {!(x && z) || y}",
                         "Task #6",
                MessageBoxButton.OK,
                MessageBoxImage.Question);
        }
    }
}
