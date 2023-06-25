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
    /// Interaction logic for AdminDeleteStudentPage.xaml
    /// </summary>
    public partial class AdminDeleteStudentPage : Page
    {
        public AdminDeleteStudentPage()
        {
            InitializeComponent();
        }

        private void SearchStudentButton_Click(object sender, RoutedEventArgs e)
        {
            string session, year, program, rollNum;
            try
            {
                session = Session_ComboBox.Text.ToString();
                year = Year_ComboBox.Text.ToString();
                program = Program_ComboBox.Text.ToString();
                rollNum = RollNo_TextBox.Text.ToString();

                var s = StudentManagement.searchStudent(session, year, program, rollNum);

                RegistrationNo_Label.Content = s.StudentID.Trim();
                Name_Label.Content = s.Name.Trim();
                FatherName_Label.Content = s.FatherName.Trim();
                Gender_Label.Content = s.Gender.Trim();
                DOB_Label.Content = s.DOB.ToString().Remove(10).Trim();
                Email_Label.Content = s.Email.Trim();
                Contact_Label.Content = s.ContactNo.Trim();
                Nationality_Label.Content = s.Nationality.Trim();

                Remove_Button.IsEnabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Student Not Found", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            string regNum = Session_ComboBox.Text.ToString() + Year_ComboBox.Text.ToString() + "-" +
                Program_ComboBox.Text.ToString() + "-" + RollNo_TextBox.Text.ToString();
            try
            {
                StudentManagement.removeStudent(regNum);
                MessageBox.Show("Student Removed Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Unable to Remove Student", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
