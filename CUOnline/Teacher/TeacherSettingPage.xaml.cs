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
using BusinessLogic;

namespace CUOnline
{
    /// <summary>
    /// Interaction logic for TeacherSettingPage.xaml
    /// </summary>
    public partial class TeacherSettingPage : Page
    {
        private string instructorID;
        public TeacherSettingPage(string id)
        {
            InitializeComponent();
            instructorID = id;
            var x = InstructorManagement.searchInstructor(instructorID);

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
                InstructorManagement.updateInstructor(instructorID, email, contact);
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
                if (oldPassword.Equals(InstructorManagement.getPassword(instructorID)))
                {
                    if (newPassword.Equals(confirmPassword))
                    {
                        InstructorManagement.setPassword(instructorID, newPassword);
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
