Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Utils

Namespace CustomDateEditTest
    Partial Public Class CustomDateEdit
        Inherits DateEdit

        #Region "Special Dates property"
        Public Shared ReadOnly SpecialDatesProperty As DependencyProperty
        Public Shared ReadOnly SpecialBorderStyleProperty As DependencyProperty

        Public Property SpecialDates() As IList(Of Date)
            Get
                Return DirectCast(GetValue(SpecialDatesProperty), IList(Of Date))
            End Get
            Set(ByVal value As IList(Of Date))
                SetValue(SpecialDatesProperty, value)
            End Set
        End Property
        Public Property SpecialBorderStyle() As Style
            Get
                Return CType(GetValue(SpecialBorderStyleProperty), Style)
            End Get
            Set(ByVal value As Style)
                SetValue(SpecialBorderStyleProperty, value)
            End Set
        End Property
        #End Region
        Public Sub New()
            InitializeComponent()
            SpecialBorderStyle = TryCast(FindResource("defaultSpecialBorderStyle"), Style)
        End Sub

        Shared Sub New()
            SpecialDatesProperty = DependencyPropertyManager.Register("SpecialDates", GetType(IList(Of Date)), GetType(CustomDateEdit))
            SpecialBorderStyleProperty = DependencyPropertyManager.Register("SpecialBorderStyle", GetType(Style), GetType(CustomDateEdit))
        End Sub
    End Class
End Namespace
