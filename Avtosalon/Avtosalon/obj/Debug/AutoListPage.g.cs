﻿#pragma checksum "..\..\AutoListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "39852E167799D99684A9C78EB172FBC5EDCA9E10807AC850BB5C427EE15894D9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Avtosalon;
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


namespace Avtosalon {
    
    
    /// <summary>
    /// AutoListPage
    /// </summary>
    public partial class AutoListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 20 "..\..\AutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBCount;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBAllRecords;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LeftDirButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PageListBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RightDirButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortCombo;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\AutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboFilter;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\AutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClientAddButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\AutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaleViewButton;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\AutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView CarsListView;
        
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
            System.Uri resourceLocater = new System.Uri("/Avtosalon;component/autolistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AutoListPage.xaml"
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
            
            #line 9 "..\..\AutoListPage.xaml"
            ((Avtosalon.AutoListPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TBAllRecords = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.LeftDirButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\AutoListPage.xaml"
            this.LeftDirButton.Click += new System.Windows.RoutedEventHandler(this.LeftDirButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PageListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 23 "..\..\AutoListPage.xaml"
            this.PageListBox.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.PageListBox_MouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RightDirButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\AutoListPage.xaml"
            this.RightDirButton.Click += new System.Windows.RoutedEventHandler(this.RightDirButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\AutoListPage.xaml"
            this.TBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBoxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SortCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\AutoListPage.xaml"
            this.SortCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ComboFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\AutoListPage.xaml"
            this.ComboFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ClientAddButton = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\AutoListPage.xaml"
            this.ClientAddButton.Click += new System.Windows.RoutedEventHandler(this.ClientAddButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\AutoListPage.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.SaleViewButton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\AutoListPage.xaml"
            this.SaleViewButton.Click += new System.Windows.RoutedEventHandler(this.SaleViewButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.CarsListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 14:
            
            #line 114 "..\..\AutoListPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditButton_Click);
            
            #line default
            #line hidden
            break;
            case 15:
            
            #line 115 "..\..\AutoListPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaleButton_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

