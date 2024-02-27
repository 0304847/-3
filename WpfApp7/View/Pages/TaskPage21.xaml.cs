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
    /// Логика взаимодействия для TaskPage21.xaml
    /// </summary>
    public partial class TaskPage21 : Page
    {
        public TaskPage21()
        {
            InitializeComponent();
            bool X = false, Y = false, Z = true;

            MessageBox.Show($"21){(X && !Y)||Z}\n2{X &&(!Y || Z)}\n3{X ||(!(Y || Z))}",
                         "Task #21",
                         MessageBoxButton.OK,
                         MessageBoxImage.Question);
        }
    }
    }
}
