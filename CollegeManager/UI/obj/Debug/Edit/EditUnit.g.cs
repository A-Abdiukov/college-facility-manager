﻿#pragma checksum "..\..\..\Edit\EditUnit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8F2DED4A6CC3DC1CA3D0E00216A215DEBC5480801EE364D60F06FD88CD2D2893"
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


namespace View.Edit {
    
    
    /// <summary>
    /// EditUnit
    /// </summary>
    public partial class EditUnit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Edit\EditUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBack_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Edit\EditUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgNavigationBar;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Edit\EditUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxSelectUnit;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Edit\EditUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Name;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Edit\EditUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Hours;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Edit\EditUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditUnit;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\Edit\EditUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDeleteUnit;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/edit/editunit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Edit\EditUnit.xaml"
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
            
            #line 8 "..\..\..\Edit\EditUnit.xaml"
            ((View.Edit.EditUnit)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Edit\EditUnit.xaml"
            ((View.Edit.EditUnit)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GoBack_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Edit\EditUnit.xaml"
            this.GoBack_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.GoBack_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DgNavigationBar = ((System.Windows.Controls.DataGrid)(target));
            
            #line 34 "..\..\..\Edit\EditUnit.xaml"
            this.DgNavigationBar.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DgNavigationBar_NavigateToSelectedPage);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ComboBoxSelectUnit = ((System.Windows.Controls.ComboBox)(target));
            
            #line 99 "..\..\..\Edit\EditUnit.xaml"
            this.ComboBoxSelectUnit.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxSelectUnit_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBox_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.textBox_Hours = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BtnEditUnit = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\..\Edit\EditUnit.xaml"
            this.BtnEditUnit.Click += new System.Windows.RoutedEventHandler(this.BtnEditUnit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnDeleteUnit = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\..\Edit\EditUnit.xaml"
            this.BtnDeleteUnit.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteUnit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

