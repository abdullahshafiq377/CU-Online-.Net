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
    /// Interaction logic for AdminSettingPage.xaml
    /// </summary>
    public partial class AdminSettingPage : Page
    {
        private string adminId;
        public AdminSettingPage(string id)
        {
            InitializeComponent();
            adminId = id;
        }

        private void Save_Button_OnClick(object sender, RoutedEventArgs e)
        {
            string oldPassword, newPassword, confirmPassword;

            oldPassword = OldPassword_PasswordBox.Password.ToString();
            newPassword = NewPassword_PasswordBox.Password.ToString();
            confirmPassword = ConfirmPassword_PasswordBox.Password.ToString();

            try
            {
                if (oldPassword.Equals(AdminManagement.getPassword(adminId)))
                {
                    if (newPassword.Equals(confirmPassword))
                    {
                        AdminManagement.setPassword(adminId, newPassword);
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
