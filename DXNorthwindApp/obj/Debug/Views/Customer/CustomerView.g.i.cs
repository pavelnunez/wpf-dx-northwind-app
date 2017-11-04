﻿#pragma checksum "..\..\..\..\Views\Customer\CustomerView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6CEB5AC86CD01DDB8187D02A4AD6588C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DXNorthwindApp.Localization;
using DXNorthwindApp.ViewModels;
using DXNorthwindApp.Views;
using DevExpress.Core;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Mvvm.UI.ModuleInjection;
using DevExpress.Mvvm.ViewModel;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.ConditionalFormatting;
using DevExpress.Xpf.Core.DataSources;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Core.ServerMode;
using DevExpress.Xpf.DXBinding;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.DataPager;
using DevExpress.Xpf.Editors.DateNavigator;
using DevExpress.Xpf.Editors.ExpressionEditor;
using DevExpress.Xpf.Editors.Filtering;
using DevExpress.Xpf.Editors.Flyout;
using DevExpress.Xpf.Editors.Popups;
using DevExpress.Xpf.Editors.Popups.Calendar;
using DevExpress.Xpf.Editors.RangeControl;
using DevExpress.Xpf.Editors.Settings;
using DevExpress.Xpf.Editors.Settings.Extension;
using DevExpress.Xpf.Editors.Validation;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.ConditionalFormatting;
using DevExpress.Xpf.Grid.LookUp;
using DevExpress.Xpf.Grid.TreeList;
using DevExpress.Xpf.LayoutControl;
using DevExpress.Xpf.Reports.UserDesigner.Extensions;
using DevExpress.Xpf.Ribbon;
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


namespace DXNorthwindApp.Views {
    
    
    /// <summary>
    /// CustomerView
    /// </summary>
    public partial class CustomerView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutControl layoutControl;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemCustomerID;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemCompanyName;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemContactName;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemContactTitle;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemAddress;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemCity;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemRegion;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemPostalCode;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemCountry;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemPhone;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemFax;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.LayoutGroup Tabs;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Grid.GridControl CustomerDemographicsDetailEntitiesGrid;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Views\Customer\CustomerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Grid.GridControl CustomerOrdersDetailsGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/DXNorthwindApp;component/views/customer/customerview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Customer\CustomerView.xaml"
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
            this.layoutControl = ((DevExpress.Xpf.LayoutControl.DataLayoutControl)(target));
            return;
            case 2:
            this.layoutItemCustomerID = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 3:
            this.layoutItemCompanyName = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 4:
            this.layoutItemContactName = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 5:
            this.layoutItemContactTitle = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 6:
            this.layoutItemAddress = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 7:
            this.layoutItemCity = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 8:
            this.layoutItemRegion = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 9:
            this.layoutItemPostalCode = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 10:
            this.layoutItemCountry = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 11:
            this.layoutItemPhone = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 12:
            this.layoutItemFax = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 13:
            this.Tabs = ((DevExpress.Xpf.LayoutControl.LayoutGroup)(target));
            return;
            case 14:
            this.CustomerDemographicsDetailEntitiesGrid = ((DevExpress.Xpf.Grid.GridControl)(target));
            return;
            case 15:
            this.CustomerOrdersDetailsGrid = ((DevExpress.Xpf.Grid.GridControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

