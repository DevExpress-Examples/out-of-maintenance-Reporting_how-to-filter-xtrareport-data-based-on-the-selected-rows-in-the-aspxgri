<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.XtraReports.v14.1.Web, Version=14.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>

    <script type="text/javascript">
        function OnGridSelectionComplete(values) {
            var sParam = "";

            for(var i = 0; i < values.length; i ++) {
                sParam += values[i].toString() + ",";
            }

            document.getElementById('HiddenField1').value = sParam;

            if (values.length == 0)
            {
                ASPxPopupControl1.Hide();
            }
            else
            {
                 reportViewer.Refresh();
                 ASPxPopupControl1.Show();
             }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
            <dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" ClientInstanceName="gridView1"
                AutoGenerateColumns="False" KeyFieldName="CategoryID">
                <Columns>
                    <dxwgv:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0">
                    </dxwgv:GridViewCommandColumn>
                    <dxwgv:GridViewDataColumn FieldName="CategoryID" VisibleIndex="1">
                    </dxwgv:GridViewDataColumn>
                    <dxwgv:GridViewDataColumn FieldName="CategoryName" VisibleIndex="2">
                    </dxwgv:GridViewDataColumn>
                </Columns>
                <ClientSideEvents SelectionChanged="function(s, e) {
                    gridView1.GetSelectedFieldValues('CategoryID', OnGridSelectionComplete);
                }" />
            </dxwgv:ASPxGridView>

            <dxpc:ASPxPopupControl ID="ASPxPopupControl1" runat="server" HeaderText="Report" ShowCloseButton="false"
                AllowDragging="true" AllowResize="true" CloseAction="None" PopupHorizontalOffset="250">

                <ContentCollection>
                    <dxpc:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                              <div style="background-color: Aqua; text-align: center; border: solid 1px; padding: 10px;
                min-width: 550px;">
                <dxxr:ReportToolbar ID="ReportToolbar1" runat="server" ReportViewer="<%#ReportViewer1%>"
                    ShowDefaultButtons="False" Width="286px">
                    <Styles>
                        <LabelStyle>
                            <Margins MarginLeft="3px" MarginRight="3px" />
                        </LabelStyle>
                    </Styles>
                    <Items>
                        <dxxr:ReportToolbarButton ItemKind="Search" ToolTip="Display the search window" />
                        <dxxr:ReportToolbarSeparator />
                        <dxxr:ReportToolbarButton ItemKind="PrintReport" ToolTip="Print the report" />
                        <dxxr:ReportToolbarButton ItemKind="PrintPage" ToolTip="Print the current page" />
                        <dxxr:ReportToolbarSeparator />
                        <dxxr:ReportToolbarButton Enabled="False" ItemKind="FirstPage" ToolTip="First Page" />
                        <dxxr:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" ToolTip="Previous Page" />
                        <dxxr:ReportToolbarLabel Text="Page" />
                        <dxxr:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
                        </dxxr:ReportToolbarComboBox>
                        <dxxr:ReportToolbarLabel Text="of" />
                        <dxxr:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
                        <dxxr:ReportToolbarButton ItemKind="NextPage" ToolTip="Next Page" />
                        <dxxr:ReportToolbarButton ItemKind="LastPage" ToolTip="Last Page" />
                        <dxxr:ReportToolbarSeparator />
                        <dxxr:ReportToolbarButton ItemKind="SaveToDisk" ToolTip="Export a report and save it to the disk" />
                        <dxxr:ReportToolbarButton ItemKind="SaveToWindow" ToolTip="Export a report and show it in a new window" />
                        <dxxr:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                            <Elements>
                                <dxxr:ListElement Text="Pdf" Value="pdf" />
                                <dxxr:ListElement Text="Xls" Value="xls" />
                                <dxxr:ListElement Text="Rtf" Value="rtf" />
                                <dxxr:ListElement Text="Mht" Value="mht" />
                                <dxxr:ListElement Text="Text" Value="txt" />
                                <dxxr:ListElement Text="Csv" Value="csv" />
                                <dxxr:ListElement Text="Image" Value="png" />
                            </Elements>
                        </dxxr:ReportToolbarComboBox>
                    </Items>
                </dxxr:ReportToolbar>
                <dxxr:ReportViewer ID="ReportViewer1" ClientInstanceName="reportViewer" runat="server" OnUnload="ReportViewer1_Unload">
                </dxxr:ReportViewer>
            </div>
                    </dxpc:PopupControlContentControl>
                </ContentCollection>
            </dxpc:ASPxPopupControl>
            <asp:HiddenField ID="HiddenField1" runat="server" />
    </div>
    </form>
</body>
</html>