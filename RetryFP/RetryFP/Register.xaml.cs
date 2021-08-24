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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        FLRepository repository;
        public Register()
        {
            InitializeComponent();
            repository = new FLRepository();
            memIDTxt.IsReadOnly = true;
            memIDTxt.Text = (repository.getMaxID() + 1).ToString();

        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)  // Register btn
        {
            if (string.IsNullOrWhiteSpace(memIDTxt.Text))
            {
                //cleardatanew
            }
            if (!string.IsNullOrWhiteSpace(fNameTxt.Text) && !string.IsNullOrWhiteSpace(lNameTxt.Text)) // add also password txt
            {
                var custInfoTable = new CustomerInfoTable();
                custInfoTable.Customer_ID = Convert.ToDecimal(memIDTxt.Text);
                custInfoTable.Customer_Firrst_Name = fNameTxt.Text;
                custInfoTable.Customer_Last_Name = lNameTxt.Text;
                custInfoTable.Customer_Password = passWordTxt.Password;
                repository.AddRecord(custInfoTable);
                //cleardatanew
                //refresh
                
            }
        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) // Last Name txt
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e) // First Name txt
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e) // Member ID txt
        {

        }

        private void memIDTxt_GotFocus(object sender, RoutedEventArgs e) // focus for ID
        {
           // memIDTxt.Text = string.Empty; // if string = Member ID then dont continue
        }

        private void fNameTxt_GotFocus(object sender, RoutedEventArgs e) // focus for first name
        {
            fNameTxt.Text = string.Empty;
        }

        private void lNameTxt_GotFocus(object sender, RoutedEventArgs e) // focus for last name
        {
            lNameTxt.Text = string.Empty;
        }

        private void passWordTxt_GotFocus(object sender, RoutedEventArgs e)  // focus for password
        {
            passWordTxt.Password = string.Empty;
        }
    }
}
