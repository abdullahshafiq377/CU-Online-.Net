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
    /// Interaction logic for TeacherAssignQuizPage.xaml
    /// </summary>
    public partial class TeacherAssignQuizPage : Page
    {
        public TeacherAssignQuizPage(string id)
        {
            InitializeComponent();
            Course_ComboBox.ItemsSource = CourseManagement.getAssignedCoursesNames(id);
        }

        private void Assign_Button_OnClick(object sender, RoutedEventArgs e)
        {
            string title, course, startDate, endDate, totalMarks, instructions;

            title = Title_TextBox.Text;
            course = Course_ComboBox.Text;
            startDate = StartDate_DatePicker.Text;
            endDate = EndDate_DatePicker.Text;
            totalMarks = TotalMarks_TextBox.Text;
            instructions = Instruction_Textbox.Text;

            try
            {
                QuizManagement.addQuiz(title, course, startDate, endDate, totalMarks, instructions);
                MessageBox.Show("Quiz Added Successfully", "Operation Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Add Quiz", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
