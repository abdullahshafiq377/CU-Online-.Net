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
    /// Interaction logic for StudentRegistrationCardPage.xaml
    /// </summary>
    public partial class StudentRegistrationCardPage : Page
    {
        public StudentRegistrationCardPage(string id)
        {
            InitializeComponent();
            coursestable.ItemsSource =  CourseManagement.GetRegistrations(id);

            var x = StudentManagement.searchStudent(id);

            Name_Label.Content = x.Name.Trim();
            Program_Label.Content = x.Program.Trim();
            Session_Label.Content = x.Batch.Remove(2, 2);
            RegNum_Label.Content = x.StudentID.Trim();
            Courses_Label.Content = CourseManagement.GetNumofRegistrations(id);
            Campus_Label.Content = "Islamabad";
        }

        private void printRegistrationCard(object sender, RoutedEventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();

        }
    }
}
