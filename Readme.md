<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128601042/13.1.11%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1613)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/App_Code/XtraReport1.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to filter XtraReport data based on the selected rows in the ASPxGridView
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1613/)**
<!-- run online end -->


<p>This example demonstrates how to filter XtraReport data based on the selected rows in the ASPxGridView. The XtraReport is placed into a separate ASPxPopupControl window. End users have the capability to resize this window and move it within a containment web page. This window is hidden automatically when there are no selected rows in the ASPxGridView.</p><p>Some key points of this example are:</p><p>1) The client ASPxClientGridView.SelectionChanged event is handled to track the rows selection.<br />
2) The client ASPxClientGridView.GetSelectedFieldValues() method is called to retrieve IDs of the selected rows.<br />
3) Selected row IDs are saved to the HiddenField, so that they will be available later on the server.<br />
4) The callback to the server initiates via the client ASPxClientReportViewer.Refresh() method.<br />
5) The IDs, previously saved in the HiddenField, are used to form the expression for the XtraReport.FilterString property.</p>

<br/>


