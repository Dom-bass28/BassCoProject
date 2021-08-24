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
using FPLibraryClass;

namespace RetryFP                                                   // Maybe only give option to shop and cart if member is signed in or registered
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // LOG IN btn
        {
            LogIn logIn = new LogIn();
            //this.Hide();
            logIn.Show();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e) // Register btn
        {
            Register register = new Register();
            //this.Hide();
            register.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) // Just shop btn
        {
            Shop shop = new Shop();
            this.Hide();
            shop.Show();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e) // About us btn
        {
            AboutUs aboutUs = new AboutUs();
            this.Hide();
            aboutUs.Show();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
