Imports System.ComponentModel.DataAnnotations

Namespace ConditionalFormatting

    Public Class ConditionalFormattingViewModel

        Private _Items As ConditionalFormatting.SaleOverviewData()

        Public Sub New()
            Items = GenerateSales()
        End Sub

        Public Property Items As SaleOverviewData()
            Get
                Return _Items
            End Get

            Private Set(ByVal value As SaleOverviewData())
                _Items = value
            End Set
        End Property
    End Class
End Namespace
