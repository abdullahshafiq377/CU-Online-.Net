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
using CUOnline;
using BusinessLogic;

namespace CUOnline
{
    /// <summary>
    /// Interaction logic for TeacherHomePage.xaml
    /// </summary>
    public partial class TeacherHomePage : Page
    {
        string instructorID;
        public TeacherHomePage(string id)
        {
            InitializeComponent();
            instructorID = id;
            var x = InstructorManagement.searchInstructor(id);
            TopNav_Name_Label.Content = x.Name;
            TeacherDashboardPage teacherDashboardPage = new TeacherDashboardPage(instructorID);
            this.HomePageFrame.Content = teacherDashboardPage;
        }

        private void SideNav_Click(object sender, RoutedEventArgs e)
        {
            if (sender == DashboardButton)
            {
                TeacherDashboardPage teacherDashboardPage = new TeacherDashboardPage(instructorID);
                this.HomePageFrame.Content = teacherDashboardPage;
            }
            else if (sender == MarkAttendanceButton)
            {
                TeacherMarkAttendancePage teacherMarkAttendancePage = new TeacherMarkAttendancePage(instructorID);
                this.HomePageFrame.Content = teacherMarkAttendancePage;
            }
            else if (sender == AssignAssignmentButton)
            {
                TeacherAssignAssignmentPage teacherAssignAssignmentPage = new TeacherAssignAssignmentPage(instructorID);
                this.HomePageFrame.Content = teacherAssignAssignmentPage;
            }
            else if (sender == AssignQuizButton)
            {
                TeacherAssignQuizPage teacherAssignQuizPage = new TeacherAssignQuizPage(instructorID);
                this.HomePageFrame.Content = teacherAssignQuizPage;
            }
            else if (sender == LearningResourcesButton)
            {
                TeacherSharingLearningResourcesPage teacherSharingLearningResourcesPage =
                    new TeacherSharingLearningResourcesPage(instructorID);
                this.HomePageFrame.Content = teacherSharingLearningResourcesPage;
            }
            else if (sender == UploadMarksButton)
            {
                TeacherUploadMarksPage teacherUploadMarksPage = new TeacherUploadMarksPage(instructorID);
                this.HomePageFrame.Content = teacherUploadMarksPage;
            }
            else if (sender == SettingsButton)
            {
                TeacherSettingPage teacherSettingPage = new TeacherSettingPage(instructorID);
                this.HomePageFrame.Content = teacherSettingPage;
            }
            else if (sender == LogoutButton)
            {
                MainWindow mainWindow = new MainWindow();
                var x = MessageBox.Show("Are you sure you want to logout", "Logout", MessageBoxButton.YesNo,
                    MessageBoxImage.Question);
                if (x == MessageBoxResult.Yes)
                {
                    Application.Current.MainWindow.Hide();
                    mainWindow.Show();
                }
            }
            
        }

        private void Profile_Button_OnClick(object sender, RoutedEventArgs e)
        {
            TeacherProfilePage teacherProfilePage = new TeacherProfilePage(instructorID);
            this.HomePageFrame.Content = teacherProfilePage;
        }
    }
}
