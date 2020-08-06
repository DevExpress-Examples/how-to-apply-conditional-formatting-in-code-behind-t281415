
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Core.ConditionalFormatting;
using System.Windows;
using System.Windows.Media;

namespace ConditionalFormatting {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            view.FormatConditions.AddRange(new List<FormatConditionBase> {
                new FormatCondition() {
                    Expression = "[SalesVsTarget] < 0.0m",
                    FieldName = "SalesVsTarget",
                    PredefinedFormatName = "RedText"
                },
                new FormatCondition() {
                    Expression = "[Profit] < 0.0",
                    FieldName = "Profit",
                    Format = new Format() {
                        Foreground = Brushes.Red
                    }
                },
                new DataBarFormatCondition() {
                    FieldName = "Sales",
                    PredefinedFormatName = "RedGradientDataBar"
                },
                new TopBottomRuleFormatCondition() {
                    Expression = "[Sales]",
                    FieldName = null,
                    PredefinedFormatName = "BoldText",
                    Rule = TopBottomRule.TopPercent,
                    Threshold = 10d
                },
                new DataBarFormatCondition() {
                    FieldName = "Profit",
                    PredefinedFormatName = "GreenGradientDataBar"
                },
                new IconSetFormatCondition() {
                    FieldName = "MarketShare",
                    PredefinedFormatName = "Quarters5IconSet"
                }
            });
        }
    }
}
