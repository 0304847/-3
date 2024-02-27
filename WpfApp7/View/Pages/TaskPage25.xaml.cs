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
    /// Логика взаимодействия для TaskPage25.xaml
    /// </summary>
    public partial class TaskPage25 : Page
    {
        public TaskPage25()
        {
            InitializeComponent();
            int A = Convert.ToInt16(Tba1), B = Convert.ToInt16(Tbb1), C = Convert.ToInt16(Tbc1), D = Convert.ToInt16(Tbd1);

            if (A/B>C/D)
            {
                MessageBox.Show($" A/B>C/D ",
                            "Task 25",
                      MessageBoxButton.OK,
                    MessageBoxImage.Question);
            }
            else
            {
                if (A/B<C/D)
                {
                    MessageBox.Show($" A/B<C/D  ",
                                "Task 25",
                          MessageBoxButton.OK,
                        MessageBoxImage.Question);
                }
                else
                {

                    MessageBox.Show($" Ошибка",
                               "Task 25",
                         MessageBoxButton.OK,
                       MessageBoxImage.Error);
                }

            }
        }
    }
}
