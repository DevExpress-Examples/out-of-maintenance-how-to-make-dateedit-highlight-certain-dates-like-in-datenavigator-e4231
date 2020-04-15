<!-- default file list -->
*Files to look at*:

* [CustomDateEdit.xaml](./CS/CustomDateEditTest/CustomDateEdit.xaml) (VB: [CustomDateEdit.xaml](./VB/CustomDateEditTest/CustomDateEdit.xaml))
* [CustomDateEdit.xaml.cs](./CS/CustomDateEditTest/CustomDateEdit.xaml.cs) (VB: [CustomDateEdit.xaml.vb](./VB/CustomDateEditTest/CustomDateEdit.xaml.vb))
* [MainWindow.xaml](./CS/CustomDateEditTest/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomDateEditTest/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomDateEditTest/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomDateEditTest/MainWindow.xaml.vb))
* [SpecialDateBorderStyleConverter.cs](./CS/CustomDateEditTest/SpecialDateBorderStyleConverter.cs) (VB: [SpecialDateBorderStyleConverter.vb](./VB/CustomDateEditTest/SpecialDateBorderStyleConverter.vb))
<!-- default file list end -->
# How to highlight certain dates in DateEdit

In version **18.2** and newer, [DateEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateEdit) displays [DateNavigator](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateNavigator.DateNavigator) in its dropdown. You can customize it using a custom [PopupContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupBaseEdit.PopupContentTemplate). We used this template to bind [SpecialDates](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateNavigator.DateNavigator.SpecialDates) to the `Dates` property within the `ViewModel` class.

```xml
```

It is also possible to set [DateNavigator.Appearance](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateNavigator.DateNavigator.Appearance?v=20.1) to customize the appearance of these dates in **v20.1**.