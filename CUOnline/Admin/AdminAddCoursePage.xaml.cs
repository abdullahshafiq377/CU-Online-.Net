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
    /// Interaction logic for AdminAddCoursePage.xaml
    /// </summary>
    public partial class AdminAddCoursePage : Page
    {
        public AdminAddCoursePage()
        {
            InitializeComponent();
        }
        
        private void AddCourseButton_Click(object sender, RoutedEventArgs e)
        {
            string courseCode, title, description, creditHours;
            try
            {
                courseCode = CourseCode_ComboBox.Text.ToString().Trim() + CourseCode_TextBox.Text.ToString().Trim();
                title = CourseName_TextBox.Text.ToString();
                description = CourseDescription_TextBox.Text.ToString();
                creditHours = CreditHours_ComboBox.Text.ToString();

                CourseManagement.addCourse(courseCode, title, description, creditHours);

                MessageBox.Show("Course Added Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to add Course", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
