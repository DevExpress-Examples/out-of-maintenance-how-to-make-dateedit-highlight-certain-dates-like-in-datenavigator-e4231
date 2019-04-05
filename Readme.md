<!-- default file list -->
*Files to look at*:

* [CustomDateEdit.xaml](./CS/CustomDateEditTest/CustomDateEdit.xaml) (VB: [CustomDateEdit.xaml](./VB/CustomDateEditTest/CustomDateEdit.xaml))
* [CustomDateEdit.xaml.cs](./CS/CustomDateEditTest/CustomDateEdit.xaml.cs) (VB: [CustomDateEdit.xaml.vb](./VB/CustomDateEditTest/CustomDateEdit.xaml.vb))
* [MainWindow.xaml](./CS/CustomDateEditTest/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomDateEditTest/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomDateEditTest/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomDateEditTest/MainWindow.xaml.vb))
* [SpecialDateBorderStyleConverter.cs](./CS/CustomDateEditTest/SpecialDateBorderStyleConverter.cs) (VB: [SpecialDateBorderStyleConverter.vb](./VB/CustomDateEditTest/SpecialDateBorderStyleConverter.vb))
<!-- default file list end -->
# How to make DateEdit highlight certain dates like in DateNavigator


<p>By default, the DateNavigator control allows you to set a collection of special dates and highlight them in bold font.</p><p>This example illustrates how to enable similar behavior in DateEdit.</p><p>First, it is necessary to create a DateEdit descendant and customize the "{dxet:DateEditThemeKey ResourceKey=CellButtonTemplate}" template.</p><p>Then, register two dependency properties - the SpecialDates property that contains a list of dates and the SpecialBorderStyle property that should contain a custom border style for date highlighting.</p>

<br/>


