﻿#pragma checksum "..\..\ClientAutoListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "088F65D6D31C35FD8AC6F4A980435712F1452F672E87FF8D80372652B67030A1"
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
    /// ClientAutoListPage
    /// </summary>
    public partial class ClientAutoListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\ClientAutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBCount;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ClientAutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBAllRecords;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ClientAutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LeftDirButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ClientAutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PageListBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ClientAutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RightDirButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ClientAutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ClientAutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortCombo;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ClientAutoListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboFilter;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\ClientAutoListPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Avtosalon;component/clientautolistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ClientAutoListPage.xaml"
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
            
            #line 9 "..\..\ClientAutoListPage.xaml"
            ((Avtosalon.ClientAutoListPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
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
            
            #line 22 "..\..\ClientAutoListPage.xaml"
            this.LeftDirButton.Click += new System.Windows.RoutedEventHandler(this.LeftDirButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PageListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 23 "..\..\ClientAutoListPage.xaml"
            this.PageListBox.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.PageListBox_MouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RightDirButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\ClientAutoListPage.xaml"
            this.RightDirButton.Click += new System.Windows.RoutedEventHandler(this.RightDirButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\ClientAutoListPage.xaml"
            this.TBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBoxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SortCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\ClientAutoListPage.xaml"
            this.SortCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ComboFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\ClientAutoListPage.xaml"
            this.ComboFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.CarsListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

