﻿#pragma checksum "..\..\..\Teacher\TeacherSettingPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3999EA1BC38E09E08DA0F41A9CA8000B0A253BECF6530E3CB1C0F9CDEC7837EA"
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
    /// TeacherSettingPage
    /// </summary>
    public partial class TeacherSettingPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Teacher\TeacherSettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox OldPassword_PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Teacher\TeacherSettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox NewPassword_PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Teacher\TeacherSettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ConfirmPassword_PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Teacher\TeacherSettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SavePassword_Button;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Teacher\TeacherSettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email_Textbox;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Teacher\TeacherSettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ContactNo_TextBox;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\Teacher\TeacherSettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/CUOnline;component/teacher/teachersettingpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Teacher\TeacherSettingPage.xaml"
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
            this.OldPassword_PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 2:
            this.NewPassword_PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.ConfirmPassword_PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.SavePassword_Button = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\Teacher\TeacherSettingPage.xaml"
            this.SavePassword_Button.Click += new System.Windows.RoutedEventHandler(this.SavePassword_Button_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Email_Textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ContactNo_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Save_Button = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\Teacher\TeacherSettingPage.xaml"
            this.Save_Button.Click += new System.Windows.RoutedEventHandler(this.Save_Button_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

