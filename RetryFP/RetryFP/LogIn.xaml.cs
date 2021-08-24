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
using FPLibraryClass;

namespace RetryFP
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window                                                       
    {
        FLRepository repository;
        public LogIn()
        {
            InitializeComponent();
            repository = new FLRepository();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) // Log in btn
        {
           var obj = repository.LogIn(Convert.ToDecimal(memIDtxt.Text), passWordtxt.Password);
            if (obj is null)
            {
                //invalid msg
            }
            else
            {
                Global.customerName = obj.Customer_Firrst_Name;
                MessageBox.Show("welcome" + obj.Customer_Firrst_Name);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // Register btn
        {
            Register register = new Register();
            this.Close();
            register.Show();
        }

        private void memIDtxt_GotFocus(object sender, RoutedEventArgs e)
        {
            memIDtxt.Text = string.Empty;
        }

        private void passWordtxt_GotFocus(object sender, RoutedEventArgs e)
        {
            passWordtxt.Password = string.Empty;
        }
    }
}
