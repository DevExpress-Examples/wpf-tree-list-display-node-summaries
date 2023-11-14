<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128657903/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T506323)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Tree List - Display Node Summaries

This example demonstrates how to define [node summaries](https://docs.devexpress.com/WPF/118490/controls-and-libraries/data-grid/data-summaries/node-summary) in XAML and code behind. Node summaries are values of aggregate functions calculated against all child nodes within a parent node. The Tree List control stores node summaries in the [TreeListView.NodeSummary](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.NodeSummary) collection and displays them in [node footers](https://docs.devexpress.com/WPF/118381/controls-and-libraries/data-grid/visual-elements/treelist-view-elements/node-footer).

![image](https://github.com/DevExpress-Examples/how-to-show-node-summaries-in-treelistview-t506323/assets/65009440/fb91b819-4fe8-4bc1-8580-a134c9153f01)

## Files to Review

* [MainWindow.xaml](./CS/TreeList_DataBinding/MainWindow.xaml)
* [MainWindow.xaml.cs](./CS/TreeList_DataBinding/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/TreeList_DataBinding/MainWindow.xaml.vb))

## Documentation

* [Node Summary](https://docs.devexpress.com/WPF/118490/controls-and-libraries/data-grid/data-summaries/node-summary)
* [Node Footer](https://docs.devexpress.com/WPF/118381/controls-and-libraries/data-grid/visual-elements/treelist-view-elements/node-footer)
* [TreeListView.NodeSummary](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.NodeSummary)
* [TreeListView.ShowNodeFooters](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.ShowNodeFooters)

## More Examples

* [WPF Tree List - Calculate Custom Node Summaries](https://github.com/DevExpress-Examples/how-to-calculate-custom-node-summaries-in-treelistview-t506349)
* [WPF Tree List - Generate Node Summaries Based on a View Model Collection](https://github.com/DevExpress-Examples/wpf-tree-list-generate-node-summaries-from-collection)
* [WPF Data Grid - Display Total Summaries](https://github.com/DevExpress-Examples/how-to-display-total-summaries-e1636)
