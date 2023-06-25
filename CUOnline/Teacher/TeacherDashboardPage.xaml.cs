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
    /// Interaction logic for TeacherDashboardPage.xaml
    /// </summary>
    public partial class TeacherDashboardPage : Page
    {
        public TeacherDashboardPage(string id)
        {
            InitializeComponent();
            Courses_Table.ItemsSource = CourseManagement.getAssignedCourses(id);
        }
    }
}
