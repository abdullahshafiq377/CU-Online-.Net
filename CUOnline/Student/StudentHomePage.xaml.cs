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
using CUOnline;

namespace CUOnline
{
    /// <summary>
    /// Interaction logic for StudentHomePage.xaml
    /// </summary>
    public partial class StudentHomePage : Page
    {
        private string _id;
        public StudentHomePage(string id)
        {
            this._id = id;
            InitializeComponent();
            StudentDashboardPage studentDashboardPage = new StudentDashboardPage(_id);
            this.HomePageFrame.Content = studentDashboardPage;
            var x = StudentManagement.searchStudent(id);
            TopNav_Name_Label.Content = x.Name;
            TopNav_RegistrationNum_Label.Content = x.StudentID;
        }

        private void SideNav_Click(object sender, RoutedEventArgs e)
        {
            if (sender == DashboardButton)
            {
                StudentDashboardPage studentDashboardPage = new StudentDashboardPage(_id); 
                this.HomePageFrame.Content = studentDashboardPage;  
            }
            else if (sender == RegistrationCardButton)
            {
                StudentRegistrationCardPage studentRegistrationCardPage = new StudentRegistrationCardPage(_id);
                this.HomePageFrame.Content = studentRegistrationCardPage;
            }
            else if (sender == ViewAttendanceButton)
            {
                StudentViewAttendancePage studentViewAttendancePage = new StudentViewAttendancePage(_id);
                this.HomePageFrame.Content = studentViewAttendancePage;
            }
            
            else if( sender == AssignmentButton)
            {
                StudentAssignmentPage studentAssignmentPage = new StudentAssignmentPage(_id);
                this.HomePageFrame.Content = studentAssignmentPage;
            }
            else if(sender == QuizButton)
            {
                StudentQuizPage studentQuizPage = new StudentQuizPage(_id);
                this.HomePageFrame.Content = studentQuizPage;
            }
            else if(sender == LearningResourcesButton)
            {
                StudentLearningResourcesPage studentLearningResourcesPage = new StudentLearningResourcesPage(_id);
                this.HomePageFrame.Content = studentLearningResourcesPage;
            }
            else if (sender == ViewMarksButton)
            {
                StudentViewMarksPage studentViewMarksPage = new StudentViewMarksPage(_id);
                this.HomePageFrame.Content = studentViewMarksPage;
            }
            else if (sender == ResultCardButton)
            {
                StudentResultCardPage studentResultCardPage = new StudentResultCardPage();
                this.HomePageFrame.Content = studentResultCardPage;
            }
            else if (sender == SettingsButton)
            {
                StudentSettingPage studentSettingPage = new StudentSettingPage(_id);
                this.HomePageFrame.Content = studentSettingPage;
            }
            else if (sender == LogoutButton)
            {
                var x = MessageBox.Show("Are you sure you want to logout", "Logout", MessageBoxButton.YesNo,
                    MessageBoxImage.Question);
                if (x == MessageBoxResult.Yes)
                {
                    MainWindow mainWindow = new MainWindow();
                    Application.Current.MainWindow.Hide();
                    mainWindow.Show();
                }
            }
        }

        private void Profile_Button_OnClick(object sender, RoutedEventArgs e)
        {
            StudentProfilePage studentProfilePage = new StudentProfilePage(_id);
            this.HomePageFrame.Content = studentProfilePage;
        }
    }
}
