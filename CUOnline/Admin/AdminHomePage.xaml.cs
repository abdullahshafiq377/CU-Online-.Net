using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using CUOnline;

namespace CUOnline
{
    /// <summary>
    /// Interaction logic for AdminHomePage.xaml
    /// </summary>
    public partial class AdminHomePage : Page
    {
        private string adminId;
        public AdminHomePage(string id)
        {
            InitializeComponent();
            adminId = id;
            AdminWelcomePage adminWelcomePage = new AdminWelcomePage();
            this.HomePageFrame.Content = adminWelcomePage;
        }

        private void SideNav_Click(object sender, RoutedEventArgs e)
        {
            if (sender == AddStudentButton)
            {
                AdminAddStudentPage adminAddStudentPage = new AdminAddStudentPage();
                this.HomePageFrame.Content = adminAddStudentPage;
            }
            else if (sender == UpdateStudentButton)
            {
                AdminUpdateStudentPage adminUpdateStudentPage = new AdminUpdateStudentPage();
                this.HomePageFrame.Content = adminUpdateStudentPage;
            }
            else if (sender == RemoveStudentButton)
            {
                AdminDeleteStudentPage adminDeleteStudentPage = new AdminDeleteStudentPage();
                this.HomePageFrame.Content = adminDeleteStudentPage;
            }
            else if (sender == AddTeacherButton)
            {
                AdminAddTeacherPage adminAddTeacherPage = new AdminAddTeacherPage();
                this.HomePageFrame.Content = adminAddTeacherPage;
            }
            else if (sender == UpdateTeacherButton)
            {
                AdminUpdateTeacherPage adminUpdateTeacherPage = new AdminUpdateTeacherPage();
                this.HomePageFrame.Content = adminUpdateTeacherPage;
            }
            else if (sender == RemoveTeacherButton)
            {
                AdminDeleteTeacherPage adminDeleteTeacherPage = new AdminDeleteTeacherPage();
                this.HomePageFrame.Content = adminDeleteTeacherPage;
            }
            else if (sender == AddCourseButton)
            {
                AdminAddCoursePage adminAddCoursePage = new AdminAddCoursePage();
                this.HomePageFrame.Content = adminAddCoursePage;
            }
            else if (sender == UpdateCourseButton)
            {
                AdminUpdateCoursePage adminUpdateCoursePage = new AdminUpdateCoursePage();
                this.HomePageFrame.Content = adminUpdateCoursePage;
            }
            else if (sender == RemoveCourseButton)
            {
                AdminDeleteCoursePage adminDeleteCoursePage = new AdminDeleteCoursePage();
                this.HomePageFrame.Content = adminDeleteCoursePage;
            }
            else if (sender == AssignCourseButton)
            {
                AdminAssignCoursePage adminAssignCoursePage = new AdminAssignCoursePage();
                this.HomePageFrame.Content = adminAssignCoursePage;
            }

            else if (sender == ResetPasswordButton)
            {
                AdminResetPasswordPage adminResetPasswordPage = new AdminResetPasswordPage();
                this.HomePageFrame.Content = adminResetPasswordPage;
            }
            else if (sender == RegisterCoursesButton)
            {
                AdminRegisterCoursePage adminRegisterCoursePage = new AdminRegisterCoursePage();
                this.HomePageFrame.Content = adminRegisterCoursePage;
            }
            else if (sender == SettingsButton)
            {
                AdminSettingPage adminSettingPage = new AdminSettingPage(adminId);
                this.HomePageFrame.Content = adminSettingPage;
            }
            else if (sender == LogoutButton)
            {
                MainWindow mainWindow = new MainWindow();
                var x = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButton.YesNo,
                    MessageBoxImage.Question);
                if (x == MessageBoxResult.Yes)
                {
                    Application.Current.MainWindow.Hide();
                    mainWindow.Show();
                }
            }
        }

        private void Logo_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminWelcomePage adminWelcomePage = new AdminWelcomePage();
            this.HomePageFrame.Content = adminWelcomePage;
        }
    }
}
