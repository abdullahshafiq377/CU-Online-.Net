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
    /// Interaction logic for TeacherMarkAttendancePage.xaml
    /// </summary>
    public partial class TeacherMarkAttendancePage : Page
    {
        public TeacherMarkAttendancePage(string id)
        {
            InitializeComponent();
            Course_ComboBox.ItemsSource = CourseManagement.getAssignedCoursesNames(id);
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
            }
            catch (Exception)
            {
                MessageBox.Show("Student Not Found", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveAttendanceButton_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
