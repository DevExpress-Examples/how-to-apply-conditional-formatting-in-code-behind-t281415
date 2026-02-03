Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core.ConditionalFormatting
Imports System.Windows
Imports System.Windows.Media

Namespace ConditionalFormatting

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim salesVsTargetFormatCondition = New FormatCondition() With {.Expression = "[SalesVsTarget] < 0.0m", .FieldName = "SalesVsTarget", .PredefinedFormatName = "RedText"}
            Me.view.FormatConditions.Add(salesVsTargetFormatCondition)
            Dim profitFormatCondition = New FormatCondition() With {.Expression = "[Profit] < 0.0", .FieldName = "Profit", .Format = New Format() With {.Foreground = Brushes.Red}}
            Me.view.FormatConditions.Add(profitFormatCondition)
            Dim salesDataBar = New DataBarFormatCondition() With {.FieldName = "Sales", .PredefinedFormatName = "RedGradientDataBar"}
            Me.view.FormatConditions.Add(salesDataBar)
            Dim topBottomRule = New TopBottomRuleFormatCondition() With {.Expression = "[Sales]", .FieldName = Nothing, .PredefinedFormatName = "BoldText", .Rule = DevExpress.Xpf.Core.ConditionalFormatting.TopBottomRule.TopPercent, .Threshold = 10R}
            Me.view.FormatConditions.Add(topBottomRule)
            Dim profitDataBar = New DataBarFormatCondition() With {.FieldName = "Profit", .PredefinedFormatName = "GreenGradientDataBar"}
            Me.view.FormatConditions.Add(profitDataBar)
            Dim marketShareIcons = New IconSetFormatCondition() With {.FieldName = "MarketShare", .PredefinedFormatName = "Quarters5IconSet"}
            Me.view.FormatConditions.Add(marketShareIcons)
        End Sub
    End Class
End Namespace
