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
    /// Логика взаимодействия для TaskPage5.xaml
    /// </summary>
    public partial class TaskPage5 : Page
    {
        public TaskPage5()
        {
            InitializeComponent();
            int A= Convert.ToInt16(TbA), B= Convert.ToInt16(TbB);
            if (A % 2 == 0 && B % 2 == 0)
            {
                MessageBox.Show($"OK",
                       "Task #5",
                       MessageBoxButton.OK,
                       MessageBoxImage.Question);

            }
            else
            {
                MessageBox.Show($"НЕ ОК",
                             "Task 5",
                             MessageBoxButton.OK,
                             MessageBoxImage.Question);
            }
        }
    }
}
