Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core.ConditionalFormatting
Imports System.Windows
Imports System.Windows.Media
Imports System.Collections.Generic

Namespace ConditionalFormatting

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.view.FormatConditions.AddRange(New List(Of FormatConditionBase) From {New DataBarFormatCondition() With {.FieldName = "Sales", .PredefinedFormatName = "RedGradientDataBar"}, New TopBottomRuleFormatCondition() With {.Expression = "[Sales]", .FieldName = Nothing, .PredefinedFormatName = "BoldText", .Rule = TopBottomRule.TopPercent, .Threshold = 10}, New FormatCondition() With {.Expression = "[SalesVsTarget] < 0.0m", .FieldName = "SalesVsTarget", .PredefinedFormatName = "RedText"}, New FormatCondition() With {.Expression = "[SalesVsTarget] > 0.0m", .FieldName = "SalesVsTarget", .PredefinedFormatName = "GreenText"}, New FormatCondition() With {.Expression = "[Profit] < 0.0", .FieldName = "Profit", .Format = New Format() With {.Foreground = Brushes.Red}}, New DataBarFormatCondition() With {.FieldName = "Profit", .PredefinedFormatName = "GreenGradientDataBar"}, New IconSetFormatCondition() With {.FieldName = "CustomersSatisfaction", .PredefinedFormatName = "Stars3IconSet"}, New IconSetFormatCondition() With {.FieldName = "MarketShare", .PredefinedFormatName = "Quarters5IconSet"}})
        End Sub
    End Class
End Namespace
