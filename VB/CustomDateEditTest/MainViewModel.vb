Imports DevExpress.Mvvm
Imports System
Imports System.Collections.ObjectModel

Namespace CustomDateEditTest

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property Dates As ObservableCollection(Of Date)
            Get
                Return GetValue(Of ObservableCollection(Of Date))()
            End Get

            Set(ByVal value As ObservableCollection(Of Date))
                SetValue(value)
            End Set
        End Property

        Public Sub New()
            Dates = New ObservableCollection(Of Date)()
            Dim today As Date = Date.Today
            Dates.Add(New DateTime(today.Year, today.Month, 3))
            Dates.Add(New DateTime(today.Year, today.Month, 4))
            Dates.Add(New DateTime(today.Year, today.Month, 5))
            Dates.Add(New DateTime(today.Year, today.Month, 12))
            Dates.Add(New DateTime(today.Year, today.Month, 13))
            Dates.Add(New DateTime(today.Year, today.Month, 14))
            Dates.Add(New DateTime(today.Year, today.Month, 21))
            Dates.Add(New DateTime(today.Year, today.Month, 22))
            Dates.Add(New DateTime(today.Year, today.Month, 23))
        End Sub
    End Class
End Namespace
