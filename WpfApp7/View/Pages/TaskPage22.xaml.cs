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
    /// Логика взаимодействия для TaskPage22.xaml
    /// </summary>
    public partial class TaskPage22 : Page
    {
        public TaskPage22()
        {
            InitializeComponent();
            int X = Convert.ToInt16(Tbx1), Y = Convert.ToInt16(Tby1);

            if((!(X<=-5 && X>5)) && (-3.5<Y<8.1)&&(X!=0))
            {
                MessageBox.Show($"значение истина",
                    "Task #22",
                    MessageBoxButton.OK,
                    MessageBoxImage.Question);

            }
            else
            {
                MessageBox.Show($"значение Ложь",
                "Task #22",
                MessageBoxButton.OK,
                MessageBoxImage.Question);
            }
    }
}
