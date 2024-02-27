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
    /// Логика взаимодействия для TaskPage27.xaml
    /// </summary>
    public partial class TaskPage27 : Page
    {
        public TaskPage27()
        {
            InitializeComponent();
            int x = Convert.ToInt16(Tbx1);
            if (x > 3 || x < -1) 
            {
                MessageBox.Show($"Условие истинна",
                    "Task #27",
                    MessageBoxButton.OK,
                    MessageBoxImage.Question);
            }
            else
            {
                MessageBox.Show($"Условие не истинна", 
                    "Task #27",
                    MessageBoxButton.OK,
                    MessageBoxImage.Question);
            }
        } 
    }
}
