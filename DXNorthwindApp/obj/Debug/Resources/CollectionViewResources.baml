   M S B A M L   `   `   `  ����I  EDXNorthwindApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:DXNorthwindApp.LocalizationDXNorthwindApp.Localization  5
   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089c _DevExpress.Xpf.Ribbon.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49af bDevExpress.Xpf.Grid.v17.1.Core, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49ak	 gDevExpress.Xpf.ReportDesigner.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a]
 YDevExpress.Mvvm.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49ag cDevExpress.Mvvm.v17.1.ViewModel, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a   CollectionView.Command.New  �� 
TargetType'   !DevExpress.Xpf.Bars.BarButtonItem!  DevExpress.Xpf.Bars.BarItem �� Property/   )DXNorthwindApp.Localization.ViewResources   Command_New �� Value �� Source*  $DevExpress.Xpf.Core.DXImageExtension   Image1  +DevExpress.Xpf.Core.Native.DXImageConverter  CollectionView.Command.Edit   Command_Edit ! CollectionView.Command.Delete   Command_Delete  CollectionView.Command.Save   Command_Save   CollectionView.Command.Reset	   Command_Reset " CollectionView.Command.Refresh
   Command_Refresh " CollectionView.Command.Reports,  &DevExpress.Xpf.Bars.BarSplitButtonItem   Command_Reports   CollectionView.Command.Count'  !DevExpress.Xpf.Bars.BarStaticItem �� 	Converter7  1DevExpress.Mvvm.UI.FormatStringConverterExtension   Command_Count   FormatString " CollectionView.GridCommand.New �� BasedOn #	 CollectionView.GridCommand.Edit %
 !CollectionView.GridCommand.Delete & "CollectionView.GridCommand.Refresh   CollectionView.RibbonControl)  #DevExpress.Xpf.Ribbon.RibbonControl4	  .DevExpress.Xpf.Core.Serialization.DXSerializer  CollectionView.RibbonPage&
   DevExpress.Xpf.Ribbon.RibbonPage   RibbonPage_Home ' #CollectionView.RibbonPageGroup.Main+  %DevExpress.Xpf.Ribbon.RibbonPageGroup   RibbonPageGroup_Tasks   AllowSimpleFormatString " CollectionView.RibbonStatusBar2  ,DevExpress.Xpf.Ribbon.RibbonStatusBarControl   CollectionView.RootContainer2  ,DevExpress.Mvvm.UI.Interactivity.Interaction'  !DevExpress.Mvvm.UI.EventToCommand�  �DevExpress.Mvvm.UI.Interactivity.EventTriggerBase`1[[System.Windows.DependencyObject, WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]   Event+  %DevExpress.Mvvm.UI.EventToCommandBase   Command-  'DevExpress.Xpf.Core.DXMessageBoxService3  -DevExpress.Xpf.Core.WindowedDocumentUIService�  �DevExpress.Mvvm.UI.ServiceBaseGeneric`1[[System.Windows.FrameworkElement, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]   YieldToParent3  -DevExpress.Mvvm.UI.LayoutSerializationService # CollectionView.GridControl.Base%  DevExpress.Xpf.Grid.GridControl)  #DevExpress.Xpf.Grid.DataControlBase ' #CollectionView.GridControl.Editable   	EventName   PassEventArgsToCommand    MarkRoutedEventsAsHandled   EventArgsConverter5  /DevExpress.Xpf.Core.EventArgsToDataRowConverter ' #CollectionView.GridControl.ReadOnly  CollectionView.TableView#  DevExpress.Xpf.Grid.TableView&   DevExpress.Xpf.Grid.DataViewBase�� 5   	   F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5   	   <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5   	   >dxr4http://schemas.devexpress.com/winfx/2008/xaml/ribbon  5   	   >dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   5   	   ZdxrudexLhttp://schemas.devexpress.com/winfx/2008/xaml/reports/userdesignerextensions 	 5   	   Cdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm  
  5	   	   :localization)clr-namespace:DXNorthwindApp.Localization  5
   	   %�  &	        &	     &	 �    &	 �    &	 P    &	 �    &	 �    &	 �    &	 c	    7   &		 �	    7  &	
 �
    7  &	 H    7  &	 �    &	 |    &	 �    &	 G    &	 �    &	 �    &	 �    7  &	     7  &	 8    �� 5      "    6/   .�5   
   ��  �@ Content# Z 6$   �� 5   
    �@ Glyph 6"   ��    $ New_16x16.png �� 5   
    �@ 
LargeGlyph 6'   ��    $ New_32x32.png �� 5   
    �@ Command 6$   �� *
NewCommand+5      �� 5      "    60   .�5   
   ��  �@ Content# Z 6$   �� 5   
    �@ Glyph 6"   ��    $ Edit_16x16.png �� 5   
    �@ 
LargeGlyph 6'   ��    $ Edit_32x32.png �� 5   
    �@ Command 6$   �� *EditCommand+�� 5   
    �@ CommandParameter 6-   �� *SelectedEntity+5      �� 5      "    62   .�5   
   ��  �@ Content# Z 6$   �� 5   
    �@ Glyph 6"   ��    $ Delete_16x16.png �� 5   
    �@ 
LargeGlyph 6'   ��    $ Delete_32x32.png �� 5   
    �@ Command 6$   �� *DeleteCommand+�� 5   
    �@ CommandParameter 6-   �� *SelectedEntity+5      �� 5       "    60   .�5!   
   ��  �@ Content# Z 6$   �� 5"   
    �@ Glyph 6"   ��    $ Save_16x16.png �� 5#   
    �@ 
LargeGlyph 6'   ��    $ Save_32x32.png �� 5$   
    �@ Command 6$   �� *SaveCommand+�� 5%   
    �@ 	IsVisible 6&   �� *AllowSaveReset+5&      �� 5'      "    61   .�5(   
   ��  �@ Content# Z	 6$   �� 5)   
    �@ Glyph 6"   ��    $ Reset_16x16.png �� 5*   
    �@ 
LargeGlyph 6'   ��    $ Reset_32x32.png �� 5+   
    �@ Command 6$   �� *ResetCommand+�� 5,   
    �@ 	IsVisible 6&   �� *AllowSaveReset+5-      �� 5.      "    63   .�5/   
   ��  �@ Content# Z
 6$   �� 50   
    �@ Glyph 6"   ��    $ Refresh_16x16.png �� 51   
    �@ 
LargeGlyph 6'   ��    $ Refresh_32x32.png �� 52   
    �@ Command 6$   �� *RefreshCommand+53      �� 54      "   63   .�55   
   ��  �@ Content# Z 6$   �� 56   
    �@ Glyph 6"   ��    $ Print_16x16.png �� 57   
    �@ 
LargeGlyph 6'   ��    $ Print_32x32.png �� 58   
    �@ ActAsDropDown . 6*   59      �� 5:      "   61   .�5;   
   ��  �@ Content 6$   �� *Entities.Count+   # Z 5<      �� 5=      8   "    6i   .�5>   
   ��  �@ Command 6$   �� *View.DataContext.NewCommand+5?      �� 5@      8   "    6k   .�5A   
   ��  �@ Command 6$   �� *View.DataContext.EditCommand+�� 5B   
    �@ CommandParameter 6-   �� *	Row.Row+5C      �� 5D      8   "    6o   .�5E   
   ��  �@ Command 6$   �� * View.DataContext.DeleteCommand+�� 5F   
    �@ CommandParameter 6-   �� *	Row.Row+5G      �� 5H      8   "    6q   .�5I   
   ��  �@ Command 6$   �� *!View.DataContext.RefreshCommand+5J      �� 5M      "   61   .�5N   
   ��  �@ RibbonStyle$ 
Office2010=�6(   �� 5O   
    �@ AllowCustomization .  6/   �� 5P   
    �@	 Enabled .  64   5Q      �� 5R      "  
 6.   .�5S   
   ��  �@
 Caption# Z 6$   5T      �� 5U      "   68   .�5V   
   ��  �@ Caption 6$   �� *EntityDisplayName+   # Z  .  5W      �� 5X      "   63   .�5Y   
   ��  �@	 Enabled .  64   5Z      �� 5]      "  �61   .�5^   
   ��  �@ BehaviorsTemplate 5_      �� 5`      .R�5a      �� .@�5b        $ Loaded��60    6?   �� *OnLoadedCommand+  5c      $ Unloaded��60    6A   �� *OnUnloadedCommand+  5d        5e       . 67     5f      5g      5h      5j      5k      �� 5n      "   64   .�5o   
   ��  �@ ItemsSource 6(   �� *
Entities+�� 5p   
    �@ CurrentItem 6(   �� *SelectedEntity+�� 5q   
    �@ ShowLoadingPanel 6-   �� *	IsLoading+�� 5r   
    �@ 
ShowBorder .  6'   5s      �� 5t      8   "   6s   .�5u   
   ��  �@ BehaviorsTemplate 5v      �� 5w      .R�5x      �� .@�5y        $ MouseDoubleClick��60   $
 TrueX�6m    .  6M   �� *EditCommand+ 5z        5{   "   5}      5~      5      5�      5�      �� 5�      8   "   6s   �� 5�      "   6-   .�5�   
   ��  �@ AllowEditing .  6)   �� 5�   
    �@ ShowFixedTotalSummary . 62   �� 5�   
    �@ AllowPerPixelScrolling . 63   5�      5�      