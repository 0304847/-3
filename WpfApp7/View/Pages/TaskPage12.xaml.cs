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
    /// Логика взаимодействия для TaskPage12.xaml
    /// </summary>
    public partial class TaskPage12 : Page
    {
        public TaskPage12()
        {
            InitializeComponent();
            InitializeComponent();
            double A = Convert.ToDouble(Tba1);
            double k = 100, b = 1000;
            if (k <= A < b)
            {
                MessageBox.Show($" Трехзначное ",
                            "Task 12",
                      MessageBoxButton.OK,
                    MessageBoxImage.Question);
            }
            else
            {

                MessageBox.Show($" Не Трехзанчное ",
                           "Task 12",
                     MessageBoxButton.OK,
                   MessageBoxImage.Question);
            }
        }
    }
}
