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
    /// Interaction logic for StudentViewMarksPage.xaml
    /// </summary>
    public partial class StudentViewMarksPage : Page
    {
        private string studentID;
        public StudentViewMarksPage(string id)
        {
            studentID = id;
            InitializeComponent();
            Courses_Table.ItemsSource = CourseManagement.GetRegistrations(id);
        }

        private void Courses_Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowColumn = dataGrid.Columns[1].GetCellContent(row).Parent as DataGridCell;
            string CellValue = ((TextBlock)RowColumn.Content).Text;

            Marks_Table.ItemsSource = CourseManagement.getMarks(CellValue, studentID);
        }
    }
}
