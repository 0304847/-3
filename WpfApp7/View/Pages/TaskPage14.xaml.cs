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
    /// Логика взаимодействия для TaskPage14.xaml
    /// </summary>
    public partial class TaskPage14 : Page
    {
        public TaskPage14()
        {
            InitializeComponent();
            int A = Convert.ToInt16(Tba1);
            if (A % 3 != 0 && A % 5 == 2)
            {
                MessageBox.Show($" чило не кратно трем и оканчивается на ноль",
                            "Task 14",
                      MessageBoxButton.OK,
                    MessageBoxImage.Question);
            }
            else
            {

                MessageBox.Show($" число кратно трем и не оканчивается на ноль",
                           "Task 14",
                     MessageBoxButton.OK,
                   MessageBoxImage.Question);
            }
        }
    }
}
