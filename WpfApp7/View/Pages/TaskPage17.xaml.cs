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
    /// Логика взаимодействия для TaskPage17.xaml
    /// </summary>
    public partial class TaskPage17 : Page
    {
        public TaskPage17()
        {
            InitializeComponent();
            int x = Convert.ToInt16(Tbx1), y = Convert.ToInt16(Tby1), z = Convert.ToInt16(Tbz1);
            if (x > 80 || y > 80 || z > 80)
            {
                MessageBox.Show($" ОК ",
                            "Task 17",
                      MessageBoxButton.OK,
                    MessageBoxImage.Question);
            }
            else
            {



                MessageBox.Show($" НЕ ОК ",
                           "Task 17",
                    MessageBoxButton.OK,
                  MessageBoxImage.Question);



            }
        }
    }
}
