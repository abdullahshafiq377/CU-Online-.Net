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
    /// Interaction logic for AdminAddStudentPage.xaml
    /// </summary>
    public partial class AdminAddStudentPage : Page
    {
        public AdminAddStudentPage()
        {
            InitializeComponent();
        }


        private void UploadImage_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string session, year, name, fatherName, program, dob, gender, email, contact, nationality, rollNum;

                session = Session_ComboBox.Text.ToString();
                year = Year_ComboBox.Text.ToString();
                rollNum = RollNum_Textbox.Text.ToString();
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

                StudentManagement.addStudent(session, year, rollNum, name, fatherName,
                    program, dob, gender, email, contact, nationality);

                MessageBox.Show("Student Added Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Unable to add Student", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
