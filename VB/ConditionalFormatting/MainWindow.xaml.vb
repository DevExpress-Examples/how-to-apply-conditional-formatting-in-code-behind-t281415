Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core.ConditionalFormatting
Imports System.Windows
Imports System.Windows.Media

Namespace ConditionalFormatting
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Dim salesVsTargetFormatCondition = New FormatCondition() With {.Expression = "[SalesVsTarget] < 0.0m", .FieldName = "SalesVsTarget", .PredefinedFormatName = "RedText"}
            view.FormatConditions.Add(salesVsTargetFormatCondition)

            Dim profitFormatCondition = New FormatCondition() With { _
                .Expression = "[Profit] < 0.0", .FieldName = "Profit", .Format = New Format() With {.Foreground = Brushes.Red} _
            }
            view.FormatConditions.Add(profitFormatCondition)

            Dim salesDataBar = New DataBarFormatCondition() With {.FieldName = "Sales", .PredefinedFormatName = "RedGradientDataBar"}
            view.FormatConditions.Add(salesDataBar)

            Dim _topBottomRule = New TopBottomRuleFormatCondition() With {.Expression = "[Sales]", .FieldName = Nothing, .PredefinedFormatName = "BoldText", .Rule = TopBottomRule.TopPercent, .Threshold = 10.0R}
            view.FormatConditions.Add(_topBottomRule)

            Dim profitDataBar = New DataBarFormatCondition() With {.FieldName = "Profit", .PredefinedFormatName = "GreenGradientDataBar"}
            view.FormatConditions.Add(profitDataBar)

            Dim marketShareIcons = New IconSetFormatCondition() With {.FieldName = "MarketShare", .PredefinedFormatName = "Quarters5IconSet"}
            view.FormatConditions.Add(marketShareIcons)
        End Sub
    End Class
End Namespace
