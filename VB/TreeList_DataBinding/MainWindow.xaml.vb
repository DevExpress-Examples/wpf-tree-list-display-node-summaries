Imports DevExpress.Data
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Grid
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace TreeList_DataBinding

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.treeListView1.ExpandAllNodes()
            Me.treeListView1.NodeSummary.Add(New TreeListSummaryItem() With {.FieldName = "Statistics", .SummaryType = SummaryItemType.Max, .ShowInColumn = "Department"})
        End Sub
    End Class

    Public Class ViewModel
        Inherits ViewModelBase

        Public Sub New()
            SourceList = GetStaff()
        End Sub

        Public Property SourceList As ObservableCollection(Of Employee)
    End Class
End Namespace
