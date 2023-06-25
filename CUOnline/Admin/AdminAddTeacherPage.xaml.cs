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
    /// Interaction logic for AdminAddTeacherPage.xaml
    /// </summary>
    public partial class AdminAddTeacherPage : Page
    {
        public AdminAddTeacherPage()
        {
            InitializeComponent();
        }

        private void UploadImage_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddTeacherButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string instructorId, name, fatherName, dob, gender, email, contact, nationality;

                instructorId = TeacherID_TextBox.Text.ToString();
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

                InstructorManagement.addInstructor(instructorId, name, fatherName, 
                    dob, gender, email, contact, nationality);

                MessageBox.Show("Teacher Added Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to add Instructor", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
