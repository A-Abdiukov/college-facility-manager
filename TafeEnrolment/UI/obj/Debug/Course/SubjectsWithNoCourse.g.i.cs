﻿#pragma checksum "..\..\..\Course\SubjectsWithNoCourse.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A59E8A2FDEEEB58A245C283C5FE3B5CCCC328C39FE823D04150B65C4A42A761B"
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
using UI;


namespace UI {
    
    
    /// <summary>
    /// SubjectsWithNoCourse
    /// </summary>
    public partial class SubjectsWithNoCourse : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Course\SubjectsWithNoCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button goBack_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Course\SubjectsWithNoCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgSubjectNoCourse;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Course\SubjectsWithNoCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgBreadcrmbs;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/course/subjectswithnocourse.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Course\SubjectsWithNoCourse.xaml"
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
            
            #line 8 "..\..\..\Course\SubjectsWithNoCourse.xaml"
            ((UI.SubjectsWithNoCourse)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.goBack_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Course\SubjectsWithNoCourse.xaml"
            this.goBack_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.goBack_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgSubjectNoCourse = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.dgBreadcrmbs = ((System.Windows.Controls.DataGrid)(target));
            
            #line 30 "..\..\..\Course\SubjectsWithNoCourse.xaml"
            this.dgBreadcrmbs.PreparingCellForEdit += new System.EventHandler<System.Windows.Controls.DataGridPreparingCellForEditEventArgs>(this.dgBreadcrmbs_NavigateToSelectedPage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

