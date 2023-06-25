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

namespace CUOnline
{
    /// <summary>
    /// Interaction logic for StudentHomePage.xaml
    /// </summary>
    public partial class StudentHomePage : Page
    {
        public StudentHomePage()
        {
            InitializeComponent();
        }

        private void SideNav_Click(object sender, RoutedEventArgs e)
        {
            if (sender == DashboardButton)
            {
                StudentDashboardPage studentDashboardPage = new StudentDashboardPage(); 
                this.HomePageFrame.Content = studentDashboardPage;  
            }
            else if (sender == RegistrationCardButton)
            {
                StudentRegistrationCardPage studentRegistrationCardPage = new StudentRegistrationCardPage();
                this.HomePageFrame.Content = studentRegistrationCardPage;
            }
            else if( sender == AssignmentButton)
            {

            }
            else if(sender == QuizButton)
            {

            }
            else if(sender == MaterialsButton)
            {

            }
            else if(sender == FeeButton)
            {

            }
        }
    }
}
