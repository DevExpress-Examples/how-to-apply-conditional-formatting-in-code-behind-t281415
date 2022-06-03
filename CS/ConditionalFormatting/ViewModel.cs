using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace ConditionalFormatting {
    public class ViewModel : ViewModelBase {
        public ViewModel() {
            Items = SaleDataModel.GetSales();
        }
        public ObservableCollection<SaleData> Items { get; set; }
    }
}
