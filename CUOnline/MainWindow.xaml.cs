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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string id, password;

            id = IDTextbox.Text.ToString().Trim();
            password = PasswordBox.Password.ToString();

            try
            {
                if ((bool)Student_RadioButton.IsChecked)
                {
                    if (Authentication.authenticateStudent(id.ToUpper(), password) != null)
                    {
                        StudentHomePage studentHomePage = new StudentHomePage(id);
                        this.Content = studentHomePage;
                    }
                    else
                        MessageBox.Show("Unable to Login", "Operation Unsuccessful", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else if ((bool)Teacher_RadioButton.IsChecked)
                {
                    if (Authentication.authenticateInstructor(id.ToUpper(), password) != null)
                    {
                        TeacherHomePage teacherHomePage = new TeacherHomePage(id);
                        this.Content = teacherHomePage;
                    }
                    else
                        MessageBox.Show("Unable to Login", "Operation Unsuccessful", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                else
                {
                    if (Authentication.authenticateAdmin(id, password) != null)
                    {
                        AdminHomePage adminHomePage = new AdminHomePage(id);
                        this.Content = adminHomePage;
                    }
                    else
                        MessageBox.Show("Unable to Login", "Operation Unsuccessful", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Login", "Operation Unsuccessful", MessageBoxButton.OK, MessageBoxImage.Error);
            }





        }
    }
}
