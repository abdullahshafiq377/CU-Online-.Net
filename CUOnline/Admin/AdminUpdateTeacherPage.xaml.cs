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
    /// Interaction logic for AdminUpdateTeacherPage.xaml
    /// </summary>
    public partial class AdminUpdateTeacherPage : Page
    {
        public AdminUpdateTeacherPage()
        {
            InitializeComponent();
        }

        private void SearchTeacherButton_Click(object sender, RoutedEventArgs e)
        {
            string instructorId = SearchTeacherID_TextBox.Text.ToString().Trim();

            try
            {
                var s = InstructorManagement.searchInstructor(instructorId);

                TeacherID_TextBox.Text = s.InstructorID.ToString().Trim();
                TeacherID_TextBox.IsEnabled = false;
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
                UpdateTeacherButton.IsEnabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Teacher Not Found", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void UploadImage_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateTeacherButton_Click(object sender, RoutedEventArgs e)
        {
            string instructorId, name, fatherName, dob, gender, email, contact, nationality;

            instructorId = SearchTeacherID_TextBox.Text.ToString().Trim();

            name = Name_TextBox.Text.ToString();
            fatherName = FatherName_TextBox.Text.ToString();
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
                InstructorManagement.updateInstructor(instructorId, name, fatherName, dob, gender, email, contact, nationality);
                MessageBox.Show("Teacher Updated Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Teacher Update Failed", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }
    }
}
