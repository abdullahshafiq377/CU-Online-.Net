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
    /// Interaction logic for AdminDeleteCoursePage.xaml
    /// </summary>
    public partial class AdminDeleteCoursePage : Page
    {
        public AdminDeleteCoursePage()
        {
            InitializeComponent();
        }

        private void SearchCourseButton_Click(object sender, RoutedEventArgs e)
        {
            string courseCode = CourseCode_ComboBox.Text.ToString().Trim() + CourseCode_TextBox.Text.ToString().Trim();

            try
            {
                var c = CourseManagement.searchCourse(courseCode);

                CourseCode_Label.Content = c.CourseCode.Trim();
                CourseName_Label.Content = c.Title.Trim();
                CreditHours_Label.Content = c.CreditHours.ToString().Trim();

                Remove_Button.IsEnabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Course Not Found", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            string courseCode = CourseCode_ComboBox.Text.ToString() + CourseCode_TextBox.Text.ToString().Trim();

            try
            {
                CourseManagement.removeCourse(courseCode);
                MessageBox.Show("Course Removed Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Unable to Remove Student", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
