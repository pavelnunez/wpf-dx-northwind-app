﻿#pragma checksum "..\..\..\..\Views\Product\ProductView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CA77C08602C1FA11C66AC6B6AE233B62"
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
    /// ProductView
    /// </summary>
    public partial class ProductView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\..\Views\Product\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutControl layoutControl;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\Product\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemProductID;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\Product\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemProductName;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Views\Product\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemQuantityPerUnit;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\Product\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemUnitPrice;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\Product\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemUnitsInStock;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\Product\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemUnitsOnOrder;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\Product\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemReorderLevel;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\Product\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemDiscontinued;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Views\Product\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemCategory;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Views\Product\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.DataLayoutItem layoutItemSupplier;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Views\Product\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.LayoutControl.LayoutGroup Tabs;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\Views\Product\ProductView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Grid.GridControl ProductOrder_DetailsDetailsGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/DXNorthwindApp;component/views/product/productview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Product\ProductView.xaml"
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
            this.layoutItemProductID = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 3:
            this.layoutItemProductName = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 4:
            this.layoutItemQuantityPerUnit = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 5:
            this.layoutItemUnitPrice = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 6:
            this.layoutItemUnitsInStock = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 7:
            this.layoutItemUnitsOnOrder = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 8:
            this.layoutItemReorderLevel = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 9:
            this.layoutItemDiscontinued = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 10:
            this.layoutItemCategory = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 11:
            this.layoutItemSupplier = ((DevExpress.Xpf.LayoutControl.DataLayoutItem)(target));
            return;
            case 12:
            this.Tabs = ((DevExpress.Xpf.LayoutControl.LayoutGroup)(target));
            return;
            case 13:
            this.ProductOrder_DetailsDetailsGrid = ((DevExpress.Xpf.Grid.GridControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

