﻿#pragma checksum "..\..\..\Add\UnitProfile.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2245F203E81A59447084D7CA7E13F827756474FBF4D388E4504F40A9158AD072"
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
using View.Add;


namespace View.Add {
    
    
    /// <summary>
    /// UnitProfile
    /// </summary>
    public partial class UnitProfile : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Add\UnitProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBack_navigation_btn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Add\UnitProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgNavigationBar;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Add\UnitProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Name;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Add\UnitProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Hours;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\Add\UnitProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddUnit;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/add/unitprofile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Add\UnitProfile.xaml"
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
            
            #line 9 "..\..\..\Add\UnitProfile.xaml"
            ((View.Add.UnitProfile)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\Add\UnitProfile.xaml"
            ((View.Add.UnitProfile)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GoBack_navigation_btn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Add\UnitProfile.xaml"
            this.GoBack_navigation_btn.Click += new System.Windows.RoutedEventHandler(this.GoBack_navigation_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DgNavigationBar = ((System.Windows.Controls.DataGrid)(target));
            
            #line 35 "..\..\..\Add\UnitProfile.xaml"
            this.DgNavigationBar.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DgNavigationBar_NavigateToSelectedPage);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBox_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textBox_Hours = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BtnAddUnit = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\Add\UnitProfile.xaml"
            this.BtnAddUnit.Click += new System.Windows.RoutedEventHandler(this.BtnAddUnit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

