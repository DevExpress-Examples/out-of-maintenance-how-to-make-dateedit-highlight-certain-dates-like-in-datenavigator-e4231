<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128644906/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4231)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/CustomDateEditTest/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomDateEditTest/MainWindow.xaml))
* [MainViewModel.cs](./CS/CustomDateEditTest/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/CustomDateEditTest/MainViewModel.vb))
<!-- default file list end -->
# How to highlight certain dates in DateEdit

In version **18.2** and newer, [DateEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateEdit) displays [DateNavigator](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateNavigator.DateNavigator) in its dropdown. You can customize it using a custom [PopupContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupBaseEdit.PopupContentTemplate). We used this template to bind [SpecialDates](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateNavigator.DateNavigator.SpecialDates) to the `Dates` property within the `ViewModel` class.

```xml
<dxe:DateEdit.PopupContentTemplate>
    <ControlTemplate>
        <dxe:DateNavigator IsMultiSelect="False" SpecialDates="{Binding RelativeSource={RelativeSource Self}, Path=(dxe:BaseEdit.OwnerEdit).DataContext.Dates}">
            <dxe:DateNavigator.StyleSettings>
                <dxe:DateNavigatorOutlookStyleSettings />
            </dxe:DateNavigator.StyleSettings>
        </dxe:DateNavigator>
    </ControlTemplate>
</dxe:DateEdit.PopupContentTemplate>
```

It is also possible to set [DateNavigator.Appearance](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateNavigator.DateNavigator.Appearance?v=20.1) to customize the appearance of these dates in **v20.1**.
