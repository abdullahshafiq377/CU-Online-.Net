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
    /// Interaction logic for AdminDeleteTeacherPage.xaml
    /// </summary>
    public partial class AdminDeleteTeacherPage : Page
    {
        public AdminDeleteTeacherPage()
        {
            InitializeComponent();
        }

        private void SearchTeacherButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string instructorId = TeacherID_TextBox.Text.ToString();

                var i = InstructorManagement.searchInstructor(instructorId);

                TeacherID_Label.Content = i.InstructorID.Trim();
                Name_Label.Content = i.Name.Trim();
                FatherName_Label.Content = i.FatherName.Trim();
                Gender_Label.Content = i.Gender.Trim();
                DOB_Label.Content = i.DOB.ToString().Remove(10).Trim();
                Email_Label.Content = i.Email.Trim();
                Contact_Label.Content = i.ContactNo.Trim();
                Nationality_Label.Content = i.Nationality.Trim();

                Remove_Button.IsEnabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Teacher Not Found", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            string instructorId = TeacherID_TextBox.Text.ToString().Trim();

            try
            {
                InstructorManagement.removeInstructor(instructorId);
                MessageBox.Show("Teacher Removed Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Remove Teacher", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
