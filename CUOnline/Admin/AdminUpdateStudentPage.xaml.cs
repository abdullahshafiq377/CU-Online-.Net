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
    /// Interaction logic for AdminUpdateStudentPage.xaml
    /// </summary>
    public partial class AdminUpdateStudentPage : Page
    {
        public AdminUpdateStudentPage()
        {
            InitializeComponent();
        }

        private void UpdateStudentButton_Click(object sender, RoutedEventArgs e)
        {
            string session, year, name, fatherName, program, dob, gender, email, contact, nationality, rollNum, regNum;

            regNum = SearchSession_ComboBox.Text.ToString() + SearchYear_ComboBox.Text.ToString() + "-" +
                SearchProgram_ComboBox.Text.ToString() + "-" + SearchRollNo_TextBox.Text.ToString();

            session = Session_ComboBox.Text.ToString();
            year = Year_ComboBox.Text.ToString();
            rollNum = RollNo_TextBox.Text.ToString();
            name = Name_TextBox.Text.ToString();
            fatherName = FatherName_TextBox.Text.ToString();
            program = Program_ComboBox.Text.ToString();
            dob = DOB_DatePicker.Text.ToString();
            if ((bool)Gender_Female_RadioButton.IsChecked)
                gender = "Female";
            else
                gender = "Male";
            email = Email_TextBox.Text.ToString();
            contact = ContactNo_TextBox.Text.ToString();
            nationality = Nationality_ComboBox.Text.ToString();

            try
            {
                StudentManagement.updateStudent(session, year, rollNum, name, fatherName,
                    program, dob, gender, email, contact, nationality, regNum);
                MessageBox.Show("Student Updated Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Student Update Failed", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void UploadImage_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchStudentButton_Click(object sender, RoutedEventArgs e)
        {
            string session, year, program, rollNum;
            session = SearchSession_ComboBox.Text.ToString();
            year = SearchYear_ComboBox.Text.ToString();
            program = SearchProgram_ComboBox.Text.ToString();
            rollNum = SearchRollNo_TextBox.Text.ToString();

            try
            {
                var s = StudentManagement.searchStudent(session, year, program, rollNum);

                Session_ComboBox.Text = s.Batch.Remove(2, 2);
                Year_ComboBox.Text = s.Batch.Remove(0, 2);
                Program_ComboBox.Text = s.Program.ToString().Trim();
                RollNo_TextBox.Text = s.StudentID.Remove(0, 9);
                Name_TextBox.Text = s.Name.Trim();
                FatherName_TextBox.Text = s.FatherName.Trim();
                DOB_DatePicker.Text = s.DOB.ToString().Trim();
                Email_TextBox.Text = s.Email.Trim();
                ContactNo_TextBox.Text = s.ContactNo.Trim();
                Nationality_ComboBox.Text = s.Nationality.ToString().Trim();

                if (s.Gender.Trim().Equals("Female"))
                {
                    Gender_Female_RadioButton.IsChecked = true;
                }
                else
                    Gender_Male_RadioButton.IsChecked = true;

                MainStackPanel.IsEnabled = true;
                UpdateStudentButton.IsEnabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Student Not Found", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
