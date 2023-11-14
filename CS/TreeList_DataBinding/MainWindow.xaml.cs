using DevExpress.Data;
using DevExpress.Mvvm;
using DevExpress.Xpf.Grid;
using System.Collections.ObjectModel;
using System.Windows;

namespace TreeList_DataBinding {
    public partial class MainWindow : Window {
        public MainWindow() {

            InitializeComponent();
            treeListView1.ExpandAllNodes();

            treeListView1.NodeSummary.Add(new TreeListSummaryItem() {
                FieldName = "Statistics",
                SummaryType = SummaryItemType.Max,
                ShowInColumn = "Department"
            });
        }
    }

    public class ViewModel : ViewModelBase {
        public ViewModel() {
            SourceList = Staff.GetStaff();
        }
        public ObservableCollection<Employee> SourceList { get; set; }
    }
}
