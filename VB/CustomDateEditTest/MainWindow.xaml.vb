Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows

Namespace CustomDateEditTest
    Partial Public Class MainWindow
        Inherits Window


        Private dates_Renamed As List(Of Date)

        Public Property Dates() As List(Of Date)
            Get
                Return dates_Renamed
            End Get
            Set(ByVal value As List(Of Date))
                dates_Renamed = value
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
            FillDates()
        End Sub

        Public Sub FillDates()
            dates_Renamed = New List(Of Date)()
            dates_Renamed.Add(New Date(Date.Now.Year, Date.Now.Month, 3))
            dates_Renamed.Add(New Date(Date.Now.Year, Date.Now.Month, 4))
            dates_Renamed.Add(New Date(Date.Now.Year, Date.Now.Month, 5))
            dates_Renamed.Add(New Date(Date.Now.Year, Date.Now.Month, 12))
            dates_Renamed.Add(New Date(Date.Now.Year, Date.Now.Month, 13))
            dates_Renamed.Add(New Date(Date.Now.Year, Date.Now.Month, 14))
            dates_Renamed.Add(New Date(Date.Now.Year, Date.Now.Month, 21))
            dates_Renamed.Add(New Date(Date.Now.Year, Date.Now.Month, 22))
            dates_Renamed.Add(New Date(Date.Now.Year, Date.Now.Month, 23))
        End Sub
    End Class
End Namespace
