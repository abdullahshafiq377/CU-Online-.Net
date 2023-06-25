using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
using BusinessLogic;
using DataLayer;

namespace CUOnline
{
    /// <summary>
    /// Interaction logic for StudentSettingPage.xaml
    /// </summary>
    public partial class StudentSettingPage : Page
    {
        private string stdID;
        public StudentSettingPage(string id)
        {
            InitializeComponent();
            stdID = id;
            var x = StudentManagement.searchStudent(stdID);

            Email_Textbox.Text = x.Email;
            ContactNo_TextBox.Text = x.ContactNo;
        }

        private void Save_Button_OnClick(object sender, RoutedEventArgs e)
        {
            string email, contact;
            email = Email_Textbox.Text;
            contact = ContactNo_TextBox.Text;

            try
            {
                StudentManagement.updateStudent(stdID, email, contact);
                MessageBox.Show("Details Updated Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Update Details", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SavePassword_Button_OnClick(object sender, RoutedEventArgs e)
        {
            string oldPassword, newPassword, confirmPassword;

            oldPassword = OldPassword_PasswordBox.Password.ToString();
            newPassword = NewPassword_PasswordBox.Password.ToString();
            confirmPassword = ConfirmPassword_PasswordBox.Password.ToString();

            try
            {
                if (oldPassword.Equals(StudentManagement.getPassword(stdID)))
                {
                    if (newPassword.Equals(confirmPassword))
                    {
                        StudentManagement.setPassword(stdID, newPassword);
                        MessageBox.Show("Password Updated Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                        MessageBox.Show("New Password and Confirm Password do not match", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Old Password Entered Wrong", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Update Password", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
