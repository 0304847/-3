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
    /// Логика взаимодействия для TaskPage4.xaml
    /// </summary>
    public partial class TaskPage4 : Page
    {
        public TaskPage4()
        {
            InitializeComponent();
            int A = Convert.ToInt16(Tba1);
            if (A % 2 == 0 && A % 3 == 0)
            {
                MessageBox.Show($" OK",
                            "Task 4",
                      MessageBoxButton.OK,
                    MessageBoxImage.Question);
            }
            else
            {

                MessageBox.Show($" Не OK",
                           "Task 4",
                     MessageBoxButton.OK,
                   MessageBoxImage.Question);
            }
        }
    }
}
