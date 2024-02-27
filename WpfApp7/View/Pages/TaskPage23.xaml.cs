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
    /// Логика взаимодействия для TaskPage23.xaml
    /// </summary>
    public partial class TaskPage23 : Page
    {
        public TaskPage23()
        {
            InitializeComponent();
            double A = Convert.ToDouble(Tba1);
            
            if ((-10>A<-1) && (2<A>15))
            {
                MessageBox.Show($" чило не принадлежит ни одному  из интервалов",
                            "Task 23",
                      MessageBoxButton.OK,
                    MessageBoxImage.Question);
            }
            else
            {

                MessageBox.Show($" число принадлежит какому-то  из интервалов",
                           "Task 23",
                     MessageBoxButton.OK,
                   MessageBoxImage.Question);
            }
        }
    }
}
