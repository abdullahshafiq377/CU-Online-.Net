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
    /// Interaction logic for AdminRegisterCoursePage.xaml
    /// </summary>
    public partial class AdminRegisterCoursePage : Page
    {
        public AdminRegisterCoursePage()
        {
            InitializeComponent();
            Courses_ComboBox.ItemsSource = CourseManagement.getCourseNames();
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

                MainStackPanel.IsEnabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Student Not Found", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RegisterCourseButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CourseManagement.RegisterCourse(Session_ComboBox.Text.ToString(), Year_ComboBox.Text.ToString(), Program_ComboBox.Text.ToString(), RollNo_TextBox.Text.ToString(), Courses_ComboBox.Text);
                MessageBox.Show("Course Registered Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Registration unsuccessful", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
