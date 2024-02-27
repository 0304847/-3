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
    /// Логика взаимодействия для TaskPage10.xaml
    /// </summary>
    public partial class TaskPage10 : Page
    {
        public TaskPage10()
        {
            InitializeComponent();
            bool A = true, B = false, C = true;

            MessageBox.Show($"10){A || !(A && B) || C}\n2{!A || C && !( B || C)}\n3{(A || B && !C) || A}",
                          "Task #10",
                          MessageBoxButton.OK,
                          MessageBoxImage.Question);

        }
    }
}
