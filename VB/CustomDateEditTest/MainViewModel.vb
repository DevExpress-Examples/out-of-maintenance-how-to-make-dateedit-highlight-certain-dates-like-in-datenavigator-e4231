Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm

Namespace CustomDateEditTest
    Public Class MainViewModel
        Inherits BindableBase

        Public Property Dates() As ObservableCollection(Of Date)
            Get
                Return GetValue(Of ObservableCollection(Of Date))()
            End Get
            Set(ByVal value As ObservableCollection(Of Date))
                SetValue(value)
            End Set
        End Property

        Public Sub New()
            Dates = New ObservableCollection(Of Date)
            Dates.Add(New Date(Date.Now.Year, Date.Now.Month, 3))
            Dates.Add(New Date(Date.Now.Year, Date.Now.Month, 4))
            Dates.Add(New Date(Date.Now.Year, Date.Now.Month, 5))
            Dates.Add(New Date(Date.Now.Year, Date.Now.Month, 12))
            Dates.Add(New Date(Date.Now.Year, Date.Now.Month, 13))
            Dates.Add(New Date(Date.Now.Year, Date.Now.Month, 14))
            Dates.Add(New Date(Date.Now.Year, Date.Now.Month, 21))
            Dates.Add(New Date(Date.Now.Year, Date.Now.Month, 22))
            Dates.Add(New Date(Date.Now.Year, Date.Now.Month, 23))
        End Sub
    End Class
End Namespace