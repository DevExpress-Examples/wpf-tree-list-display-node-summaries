using DevExpress.Data;
using DevExpress.Mvvm;
using DevExpress.Xpf.Grid;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace TreeList_DataBinding {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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

    public class ViewModel : ViewModelBase
    {
        public ObservableCollection<Employee> SourceList
        {
            get { return GetProperty(() => SourceList); }
            set { SetProperty(() => SourceList, value); }
        }

        public ViewModel()
        {
            SourceList = Stuff.GetStuff();
        }
    }
}
