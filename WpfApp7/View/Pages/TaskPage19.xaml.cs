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
    /// Логика взаимодействия для TaskPage19.xaml
    /// </summary>
    public partial class TaskPage19 : Page
    {
        public TaskPage19()
        {
            InitializeComponent();

            bool A = false,B = false, C = true;

            MessageBox.Show($"19){( !A|| !B)&&!C}\n2{(!A || !B) && ( A || B)}\n3{A && B || A && C || !C}",
                         "Task #19",
                         MessageBoxButton.OK,
                         MessageBoxImage.Question);
        }
    }
    }
}
