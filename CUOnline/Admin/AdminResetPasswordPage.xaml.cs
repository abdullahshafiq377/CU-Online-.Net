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
    /// Interaction logic for AdminResetPasswordPage.xaml
    /// </summary>
    public partial class AdminResetPasswordPage : Page
    {
        public AdminResetPasswordPage()
        {
            InitializeComponent();
        }

        private void ResetStudentPassword_Button_Click(object sender, RoutedEventArgs e)
        {
            string session, year, program, rollNum;
            session = Session_ComboBox.Text.ToString();
            year = Year_ComboBox.Text.ToString();
            program = Program_ComboBox.Text.ToString();
            rollNum = RollNum_Textbox.Text.ToString().Trim();
            try
            {
                StudentManagement.resetStudentPassword(session, year, program, rollNum);
                MessageBox.Show("Password Reset Successful", "Operation Succeccful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Unable to Reset Password", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ResetTeacherPassword_Button_Click(object sender, RoutedEventArgs e)
        {
            string instructorId = TeacherID_TextBox.Text.ToString().Trim();

            try
            {
                InstructorManagement.resetInstructorPassword(instructorId);
                MessageBox.Show("Password Reset Successful", "Operation Succeccful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Unable to Reset Password", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
