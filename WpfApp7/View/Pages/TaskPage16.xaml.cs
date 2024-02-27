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
    /// Логика взаимодействия для TaskPage16.xaml
    /// </summary>
    public partial class TaskPage16 : Page
    {
        public TaskPage16()
        {
            InitializeComponent();
            int x = Convert.ToInt16(Tbx1), y = Convert.ToInt16(Tby1), z = Convert.ToInt16(Tbz1);
            if (x % 5 == 0 && y % 5 != 0 && z % 5 != 0)
            {
                MessageBox.Show($" ОК ",
                            "Task 17",
                      MessageBoxButton.OK,
                    MessageBoxImage.Question);
            }
            else
            {
                if (x % 5 != 0 && y % 5 == 0 && z % 5 != 0)
                {
                    MessageBox.Show($" ОК ",
                                "Task 17",
                          MessageBoxButton.OK,
                        MessageBoxImage.Question);
                }
                else
                {
                    if (x % 5 != 0 && y % 5 != 0 && z % 5 == 0)
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
    }
}
