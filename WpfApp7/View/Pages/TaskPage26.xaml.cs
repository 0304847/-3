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
    /// Логика взаимодействия для TaskPage26.xaml
    /// </summary>
    public partial class TaskPage26 : Page
    {
        public TaskPage26()
        {
            InitializeComponent();
            int x = Convert.ToInt16(Tbx1), y = Convert.ToInt16(Tby1);

            if ((!((x<=-5)&&(x>5))) && ((-3.5<y<=8.1)&&(x!=0)))
            {
                MessageBox.Show($" Оба условия верны",
                            "Task 26",
                      MessageBoxButton.OK,
                    MessageBoxImage.Question);
            }
            else
            {
                
                

               MessageBox.Show($" Ошибка оба условия не верны ",
                               "Task 26",
                         MessageBoxButton.OK,
                       MessageBoxImage.Error);
                

            }
        }
    }
}
