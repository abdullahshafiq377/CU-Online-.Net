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
    /// Interaction logic for TeacherSharingLearningResourcesPage.xaml
    /// </summary>
    public partial class TeacherSharingLearningResourcesPage : Page
    {
        public TeacherSharingLearningResourcesPage(string id)
        {
            InitializeComponent();
            Course_ComboBox.ItemsSource = CourseManagement.getAssignedCoursesNames(id);
        }

        private void AddResource_Button_OnClick(object sender, RoutedEventArgs e)
        {
            string title, course;
            title = Title_TextBox.Text;
            course = Course_ComboBox.Text;

            try
            {
                LearningResourcesManagement.addLearningResource(title, course);
                MessageBox.Show("Resource Added Successfully", "Operation Seccessful", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to add Resource", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
