﻿#pragma checksum "..\..\..\Add\TeacherProfile.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4D15ED8996AD532A4628007470871A034978318BCDCCA7D31A813B8E31666F8E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace View.Teacher {
    
    
    /// <summary>
    /// TeacherProfile
    /// </summary>
    public partial class TeacherProfile : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Add\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBack_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Add\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgNavigationBar;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Add\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddTeacher;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Add\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Address;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\Add\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_GenderSelection;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\Add\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_PhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Add\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Email;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Add\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker_DateOfBirth;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\Add\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_FirstName;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\Add\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_LastName;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\Add\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_Course;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\Add\TeacherProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_Locations;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/add/teacherprofile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Add\TeacherProfile.xaml"
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
            
            #line 8 "..\..\..\Add\TeacherProfile.xaml"
            ((View.Teacher.TeacherProfile)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Add\TeacherProfile.xaml"
            ((View.Teacher.TeacherProfile)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GoBack_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Add\TeacherProfile.xaml"
            this.GoBack_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.GoBack_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DgNavigationBar = ((System.Windows.Controls.DataGrid)(target));
            
            #line 35 "..\..\..\Add\TeacherProfile.xaml"
            this.DgNavigationBar.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DgNavigationBar_NavigateToSelectedPage);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnAddTeacher = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\Add\TeacherProfile.xaml"
            this.BtnAddTeacher.Click += new System.Windows.RoutedEventHandler(this.BtnAddTeacher_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBox_Address = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.comboBox_GenderSelection = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.textBox_PhoneNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.textBox_Email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.datePicker_DateOfBirth = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.textBox_FirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.textBox_LastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.comboBox_Course = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.comboBox_Locations = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

