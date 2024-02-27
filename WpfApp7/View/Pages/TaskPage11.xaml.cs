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
    /// Логика взаимодействия для TaskPage11.xaml
    /// </summary>
    public partial class TaskPage11 : Page
    {
        public TaskPage11()
        {
            InitializeComponent();
            int X = Convert.ToInt16(Tbx1), Y = Convert.ToInt16(Tby1);

            if (X == 1 && Y == 2)
            {
                MessageBox.Show($"11){(!(X * Y < 1)) && (Y > X)}",
                    "Task #11",
                    MessageBoxButton.OK,
                    MessageBoxImage.Question);

            }
            else
            {
                if (X == 2 && Y == 1)
                {
                    MessageBox.Show($"11){(X * Y != 0) || (Y < X)}",
                        "Task #11",
                        MessageBoxButton.OK,
                        MessageBoxImage.Question);



                }
                else
                {
                    MessageBox.Show($"11){"Ошибка!!! x=1 или 2 ; y=2 или 1"}",
                    "Task #11",
                    MessageBoxButton.OK,
                    MessageBoxImage.Question);
                }
            }
        }
    }
}
