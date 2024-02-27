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
using WpfApp7.Core;
using WpfApp7.View.Pages;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainNavCore.MainNavFrame = MainFrame;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage1());
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage2());
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage3());
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage4());
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage5());
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage6());
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage7());
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage8());
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage9());
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage10());
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage11());
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage12());
        }

        private void btn13_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage13());
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage14());
        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage15());
        }

        private void btn16_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage16());
        }

        private void btn17_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage17());
        }

        private void btn18_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage18());
        }

        private void btn19_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage19());
        }

        private void btn20_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage20());
        }

        private void btn21_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage21());
        }

        private void btn22_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage22());
        }

        private void btn23_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage23());
        }

        private void btn24_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage24());
        }

        private void btn25_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage25());
        }

        private void btn26_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage26());
        }

        private void btn27_Click(object sender, RoutedEventArgs e)
        {
            MainNavCore.MainNavFrame.Navigate(new TaskPage27());
        }
    }
}
