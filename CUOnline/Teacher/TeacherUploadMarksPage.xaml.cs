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
    /// Interaction logic for TeacherUploadMarksPage.xaml
    /// </summary>
    public partial class TeacherUploadMarksPage : Page
    {
        public TeacherUploadMarksPage(string id)
        {
            InitializeComponent();
            Courses_ComboBox.ItemsSource = CourseManagement.getAssignedCoursesNames(id);
        }

        private void SearchStudentButton_OnClick(object sender, RoutedEventArgs e)
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
            }
            catch (Exception)
            {
                MessageBox.Show("Student Not Found", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveMarksButton_OnClick(object sender, RoutedEventArgs e)
        {
            string title, totalMarks, obtainedMarks;
            try
            {
                title = Title_TextBox.Text;
            totalMarks = TotalMarks_TextBox.Text;
            obtainedMarks = ObtainedMarks_TextBox.Text;

            string session, year, program, rollNum;
            session = Session_ComboBox.Text.ToString();
            year = Year_ComboBox.Text.ToString();
            program = Program_ComboBox.Text.ToString();
            rollNum = RollNo_TextBox.Text.ToString();

            string studentID = session + year + "-" + program + "-" + rollNum;
            string courseID = Courses_ComboBox.Text.Remove(6);


            
                CourseManagement.addMarks(studentID, courseID, title, totalMarks, obtainedMarks);
                MessageBox.Show("Marks Added Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Add Marks", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
