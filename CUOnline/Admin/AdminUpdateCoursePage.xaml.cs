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
    /// Interaction logic for AdminUpdateCoursePage.xaml
    /// </summary>
    public partial class AdminUpdateCoursePage : Page
    {
        public AdminUpdateCoursePage()
        {
            InitializeComponent();
        }

        private void SearchCourse_Button_Click(object sender, RoutedEventArgs e)
        {
            string courseCode = SearchCourseCode_ComboBox.Text.ToString().Trim() + SearchCourseCode_TextBox.Text.ToString().Trim();

            try
            {
                var c = CourseManagement.searchCourse(courseCode);

                CourseCode_ComboBox.Text = c.CourseCode.ToString().Remove(3).Trim();
                CourseCode_TextBox.Text = c.CourseCode.ToString().Remove(0, 3).Trim();

                CourseCode_ComboBox.IsEnabled = false;
                CourseCode_TextBox.IsEnabled = false;

                CourseName_TextBox.Text = c.Title.ToString();
                CreditHours_ComboBox.Text = c.CreditHours.ToString().Trim();
                CourseDescription_TextBox.Text = c.Description.ToString();

                MainStackPanel.IsEnabled = true;
                UpdateCourse_Button.IsEnabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Course Not Found", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UpdateCourse_Button_Click(object sender, RoutedEventArgs e)
        {
            string courseCode, title, description, creditHours;

            courseCode = CourseCode_ComboBox.Text.ToString() + CourseCode_TextBox.Text.ToString().Trim();
            title = CourseName_TextBox.Text.ToString();
            description = CourseDescription_TextBox.Text.ToString();
            creditHours = CreditHours_ComboBox.Text.ToString();

            try
            {
                CourseManagement.updateCourse(courseCode, title, description, creditHours);
                MessageBox.Show("Course Updated Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Course Update Failed", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
