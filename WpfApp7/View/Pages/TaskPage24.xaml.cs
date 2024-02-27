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
    /// Логика взаимодействия для TaskPage24.xaml
    /// </summary>
    public partial class TaskPage24 : Page
    {
        public TaskPage24()
        {
            InitializeComponent();
            double A = Convert.ToDouble(Tba1);
            if ((999<A<10000) && (A!=4999))
            {
                MessageBox.Show($" число 4-х значное и не =4999 ",
                            "Task 24",
                      MessageBoxButton.OK,
                    MessageBoxImage.Question);
            }
            else
            {

                MessageBox.Show($" число не 4-х значное или =4999",
                           "Task 24",
                     MessageBoxButton.OK,
                   MessageBoxImage.Question);
            }
        }
    }
}
