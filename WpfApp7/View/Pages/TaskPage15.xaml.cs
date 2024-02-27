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
    /// Логика взаимодействия для TaskPage15.xaml
    /// </summary>
    public partial class TaskPage15 : Page
    {
        public TaskPage15()
        {
            InitializeComponent();
            int A = Convert.ToInt16(Tba1);
            if((-137<=A<=-51) || ( 55<=A<=123))
            {
                MessageBox.Show($" чило принадлежит какому-то из интервалов",
                            "Task 15",
                      MessageBoxButton.OK,
                    MessageBoxImage.Question);
            }
            else
            {

                MessageBox.Show($" число не принадлежит не одному  из интервалов",
                           "Task 15",
                     MessageBoxButton.OK,
                   MessageBoxImage.Question);
            }
        }
    }
}
