﻿#pragma checksum "..\..\..\..\..\Views\SkinView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5F4FE9BCAE050DDB17783A7D9D18A3B3371B460E"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Tra.Traline.Launcher.ViewModels;
using Tra.Traline.Launcher.Views;


namespace Tra.Traline.Launcher.Views {
    
    
    /// <summary>
    /// SkinView
    /// </summary>
    public partial class SkinView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\..\..\..\Views\SkinView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox c_lbx;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tra.Traline.Launcher;component/views/skinview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\SkinView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.c_lbx = ((System.Windows.Controls.ListBox)(target));
            
            #line 24 "..\..\..\..\..\Views\SkinView.xaml"
            this.c_lbx.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectItem_LbxSelectionChanged);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\..\..\Views\SkinView.xaml"
            this.c_lbx.KeyDown += new System.Windows.Input.KeyEventHandler(this.ListBox_KeyDown);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\..\..\Views\SkinView.xaml"
            this.c_lbx.MouseMove += new System.Windows.Input.MouseEventHandler(this.ListBox_MouseMove);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\..\..\Views\SkinView.xaml"
            this.c_lbx.Drop += new System.Windows.DragEventHandler(this.ListBox_Drop);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 84 "..\..\..\..\..\Views\SkinView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 90 "..\..\..\..\..\Views\SkinView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 2:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 31 "..\..\..\..\..\Views\SkinView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.StartEdit_MouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 3:
            
            #line 50 "..\..\..\..\..\Views\SkinView.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.EditName_TextChanged);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\..\..\Views\SkinView.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.EndEdit_LostKeyboardFocus);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

