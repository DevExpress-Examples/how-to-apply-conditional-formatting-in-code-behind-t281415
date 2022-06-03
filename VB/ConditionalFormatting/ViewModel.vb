Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace ConditionalFormatting

    Public Class ViewModel
        Inherits ViewModelBase

        Public Sub New()
            Items = GetSales()
        End Sub

        Public Property Items As ObservableCollection(Of SaleData)
    End Class
End Namespace
