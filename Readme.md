# How to make DateEdit highlight certain dates like in DateNavigator


<p>By default, the DateNavigator control allows you to set a collection of special dates and highlight them in bold font.</p><p>This example illustrates how to enable similar behavior in DateEdit.</p><p>First, it is necessary to create a DateEdit descendant and customize the "{dxet:DateEditThemeKey ResourceKey=CellButtonTemplate}" template.</p><p>Then, register two dependency properties - the SpecialDates property that contains a list of dates and the SpecialBorderStyle property that should contain a custom border style for date highlighting.</p>

<br/>


