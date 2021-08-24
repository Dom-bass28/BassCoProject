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
using System.Windows.Shapes;

namespace RetryFP
{
    /// <summary>
    /// Interaction logic for AboutUs.xaml                     
    /// </summary>
    public partial class AboutUs : Window
    {
        public AboutUs()
        {
            InitializeComponent();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // Go back btn
        {
            MainWindow mw = new MainWindow();
            this.Hide();
            mw.Show();
        }
    }
}
