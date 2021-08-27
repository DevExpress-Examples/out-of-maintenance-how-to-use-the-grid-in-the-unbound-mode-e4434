<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632295/12.1.9%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4434)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [UnboundDataSource.cs](./CS/E4434/CustomGrid/UnboundDataSource.cs) (VB: [UnboundDataSource.vb](./VB/E4434/CustomGrid/UnboundDataSource.vb))
* [UnboundGridControl.cs](./CS/E4434/CustomGrid/UnboundGridControl.cs) (VB: [UnboundGridControl.vb](./VB/E4434/CustomGrid/UnboundGridControl.vb))
* [UnboundGridView.cs](./CS/E4434/CustomGrid/UnboundGridView.cs) (VB: [UnboundGridView.vb](./VB/E4434/CustomGrid/UnboundGridView.vb))
* [UnboundGridViewInfoRegistrator.cs](./CS/E4434/CustomGrid/UnboundGridViewInfoRegistrator.cs) (VB: [UnboundGridViewInfoRegistrator.vb](./VB/E4434/CustomGrid/UnboundGridViewInfoRegistrator.vb))
* [Form1.cs](./CS/E4434/Form1.cs) (VB: [Form1.vb](./VB/E4434/Form1.vb))
* [Program.cs](./CS/E4434/Program.cs) (VB: [Program.vb](./VB/E4434/Program.vb))
<!-- default file list end -->
# How to use the Grid in the Unbound mode


<p>The XtraGrid unlike the TreeList can't be used in the Unbound mode. It must always be bound to a datasource. This example illustrates how to emulate the Unbound mode for the XtraGrid.</p><p>As well as in case of using the TreeList, it is necessary to add unbound columns to the XtraGrid and use the AppendRow method to add a new record.</p>

<br/>


