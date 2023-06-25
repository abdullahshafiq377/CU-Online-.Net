﻿using System;
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
    /// Interaction logic for StudentDashboardPage.xaml
    /// </summary>
    public partial class StudentDashboardPage : Page
    {
        public StudentDashboardPage(string id)
        {
            InitializeComponent();
            tbl_courses.ItemsSource = CourseManagement.GetRegistrations(id);
        }
        
    }
}
