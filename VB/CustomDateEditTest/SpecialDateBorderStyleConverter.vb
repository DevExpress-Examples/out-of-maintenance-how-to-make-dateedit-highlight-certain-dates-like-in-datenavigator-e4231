Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Markup
Imports System.Windows.Data
Imports DevExpress.Xpf.Editors.Popups.Calendar
Imports System.Windows

Namespace CustomDateEditTest
    Public Class SpecialDateBorderStyleConverter
        Inherits MarkupExtension
        Implements IMultiValueConverter

        Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
            Dim specialDatesList As List(Of Date) = TryCast(values(0), List(Of Date))
            Dim currentCellButton As CalendarCellButton = DirectCast(values(1), CalendarCellButton)
            Dim dt As Date = CDate(DateEditCalendar.GetDateTime(CType(currentCellButton, DependencyObject)))
dt=dt.Date
            Return specialDatesList.Contains(dt)
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
    End Class
End Namespace
