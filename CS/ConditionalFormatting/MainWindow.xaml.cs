using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Core.ConditionalFormatting;
using System.Windows;
using System.Windows.Media;
using System.Collections.Generic;

namespace ConditionalFormatting {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            view.FormatConditions.AddRange(new List<FormatConditionBase> {
                new DataBarFormatCondition() {
                    FieldName = "Sales",
                    PredefinedFormatName = "RedGradientDataBar"
                },
                new TopBottomRuleFormatCondition() {
                    Expression = "[Sales]",
                    FieldName = null,
                    PredefinedFormatName = "BoldText",
                    Rule = TopBottomRule.TopPercent,
                    Threshold = 10
                },
                new FormatCondition() {
                    Expression = "[SalesVsTarget] < 0.0m",
                    FieldName = "SalesVsTarget",
                    PredefinedFormatName = "RedText"
                },
                new FormatCondition() {
                    Expression = "[SalesVsTarget] > 0.0m",
                    FieldName = "SalesVsTarget",
                    PredefinedFormatName = "GreenText"
                },
                new FormatCondition() {
                    Expression = "[Profit] < 0.0",
                    FieldName = "Profit",
                    Format = new Format() {
                        Foreground = Brushes.Red
                    }
                },
                new DataBarFormatCondition() {
                    FieldName = "Profit",
                    PredefinedFormatName = "GreenGradientDataBar"
                },
                new IconSetFormatCondition() {
                    FieldName = "CustomersSatisfaction",
                    PredefinedFormatName = "Stars3IconSet"
                },
                new IconSetFormatCondition() {
                    FieldName = "MarketShare",
                    PredefinedFormatName = "Quarters5IconSet"
                }
            });
        }
    }
}
