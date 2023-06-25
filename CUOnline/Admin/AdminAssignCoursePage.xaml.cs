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
    /// Interaction logic for AdminAssignCoursePage.xaml
    /// </summary>
    public partial class AdminAssignCoursePage : Page
    {
        public AdminAssignCoursePage()
        {
            InitializeComponent();
            Course_ComboBox.ItemsSource = CourseManagement.getCourseNames();
            Teacher_ComboBox.ItemsSource = InstructorManagement.getInstructorIDs();
            AssignedTeachers_DataGrid.ItemsSource = CourseManagement.getAllAssignedCourses();
        }

        private void Assign_Button_Click(object sender, RoutedEventArgs e)
        {
            string course, instructorID;
            try
            {
                course = Course_ComboBox.Text;
                instructorID = Teacher_ComboBox.Text;
                CourseManagement.assignCourse(instructorID, course);
                AssignedTeachers_DataGrid.ItemsSource = null;
                AssignedTeachers_DataGrid.ItemsSource = CourseManagement.getAllAssignedCourses();
                MessageBox.Show("Course Assigned Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Assign Course", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
