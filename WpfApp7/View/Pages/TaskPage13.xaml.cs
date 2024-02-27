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
    /// Логика взаимодействия для TaskPage13.xaml
    /// </summary>
    public partial class TaskPage13 : Page
    {
        public TaskPage13()
        {
            InitializeComponent();
            int A = Convert.ToInt16(Tba1), B = Convert.ToInt16(Tbb1), C = Convert.ToInt16(Tbc1);
            if ( A<45 && C>45 && B>45 )
            {
                MessageBox.Show($" ОК ",
                            "Task 13",
                      MessageBoxButton.OK,
                    MessageBoxImage.Question);
            }
            else
            {
                if (A > 45 && C < 45 && B > 45)
                {
                    MessageBox.Show($" ОК ",
                               "Task 13",
                         MessageBoxButton.OK,
                       MessageBoxImage.Question);
                }
                else
                {
                    if (A > 45 && C > 45 && B < 45)
                    {
                        MessageBox.Show($" ОК ",
                           "Task 13",
                           MessageBoxButton.OK,
                           MessageBoxImage.Question);
                    }
                    else
                    {
                        MessageBox.Show($" НЕ ОК ",
                               "Task 13",
                         MessageBoxButton.OK,
                       MessageBoxImage.Question);
                    }

                }
            }
        }
    }
}
