﻿#pragma checksum "..\..\..\Admin\AdminUpdateCoursePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7907D4671B0E4E8D7B3FB8275E3D8AF12E5F70D71AE900FD2C5CACD160C668F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CUOnline;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CUOnline {
    
    
    /// <summary>
    /// AdminUpdateCoursePage
    /// </summary>
    public partial class AdminUpdateCoursePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\Admin\AdminUpdateCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SearchCourseCode_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Admin\AdminUpdateCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchCourseCode_TextBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Admin\AdminUpdateCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchCourse_Button;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Admin\AdminUpdateCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MainStackPanel;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Admin\AdminUpdateCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CourseCode_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Admin\AdminUpdateCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CourseCode_TextBox;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Admin\AdminUpdateCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CourseName_TextBox;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\Admin\AdminUpdateCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CreditHours_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\Admin\AdminUpdateCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CourseDescription_TextBox;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\Admin\AdminUpdateCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateCourse_Button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CUOnline;component/admin/adminupdatecoursepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Admin\AdminUpdateCoursePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SearchCourseCode_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.SearchCourseCode_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SearchCourse_Button = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Admin\AdminUpdateCoursePage.xaml"
            this.SearchCourse_Button.Click += new System.Windows.RoutedEventHandler(this.SearchCourse_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MainStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.CourseCode_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.CourseCode_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CourseName_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.CreditHours_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.CourseDescription_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.UpdateCourse_Button = ((System.Windows.Controls.Button)(target));
            
            #line 154 "..\..\..\Admin\AdminUpdateCoursePage.xaml"
            this.UpdateCourse_Button.Click += new System.Windows.RoutedEventHandler(this.UpdateCourse_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

