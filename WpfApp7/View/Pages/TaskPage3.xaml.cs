using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// Логика взаимодействия для TaskPage3.xaml
    /// </summary>
    public partial class TaskPage3 : Page
    {
        public TaskPage3()
        {
            InitializeComponent();
            int X = Convert.ToInt16(Tbx1), Y = Convert.ToInt16(Tby1);

            if (X == 2 && Y == 1)
            {
                MessageBox.Show($"3){(!(X * Y < 0)) && (Y > X)}",
                    "Task #3",
                    MessageBoxButton.OK,
                    MessageBoxImage.Question);

            }
            else
            {
                if (X == 2 && Y == -2)
                {
                    MessageBox.Show($"3){(X >= 2) || (Math.Pow(Y, 2) == 5)}",
                        "Task #3",
                        MessageBoxButton.OK,
                        MessageBoxImage.Question);



                }
                else
                {
                    MessageBox.Show($"3){"Ошибка!!! x=2 y=1 или -2"}",
                    "Task #3",
                    MessageBoxButton.OK,
                    MessageBoxImage.Question);
                }

            }
        }
    }    
}
