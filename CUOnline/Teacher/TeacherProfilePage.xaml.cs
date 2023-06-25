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
    /// Interaction logic for TeacherProfilePage.xaml
    /// </summary>
    public partial class TeacherProfilePage : Page
    {
        public TeacherProfilePage(string id)
        {
            InitializeComponent();
            var x = InstructorManagement.searchInstructor(id);

            TeacherId_Label.Content = x.InstructorID;
            Name_Label.Content = x.Name;
            FatherName_Label.Content = x.FatherName;
            Gender_Label.Content = x.Gender;
            DOB_Label.Content = x.DOB.ToString().Remove(10);
            Nationality_Label.Content = x.Nationality;
            Email_Label.Content = x.Email;
            Contact_Label.Content = x.ContactNo;
        }
    }
}
