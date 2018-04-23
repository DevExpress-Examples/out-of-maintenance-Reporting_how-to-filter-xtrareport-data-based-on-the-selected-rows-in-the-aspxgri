Imports System
Imports DevExpress.Web.ASPxGridView
Imports nwndDataSetTableAdapters

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim ds As nwndDataSet = GetData()

		ASPxGridView1.DataSource = ds
		ASPxGridView1.DataMember = ds.Categories.TableName

		ASPxGridView1.DataBind()

		Dim report As XtraReport1 = GetReport()
		Dim selectedIDs As String = HiddenField1.Value.Trim(New Char() { ","c })

		report.FilterString = String.Format("CategoryID in ({0})", selectedIDs)
		report.CreateDocument()
		ReportViewer1.Report = report
	End Sub

	Protected Sub ReportViewer1_Unload(ByVal sender As Object, ByVal e As EventArgs)
		ReportViewer1.Report = Nothing
	End Sub

	Protected Function GetReport() As XtraReport1
		If DirectCast(Session("report"), XtraReport1) Is Nothing Then
			Dim report As New XtraReport1()
			report.DataSource = GetData()

			Session("report") = report
		End If

		Return DirectCast(Session("report"), XtraReport1)
	End Function

	Protected Function GetData() As nwndDataSet
		If DirectCast(Session("dataset"), nwndDataSet) Is Nothing Then
			Dim ds As New nwndDataSet()
			Dim cta As New CategoriesTableAdapter()
			Dim pta As New ProductsTableAdapter()

			cta.Fill(ds.Categories)
			pta.Fill(ds.Products)

			Session("dataset") = ds
		End If

		Return DirectCast(Session("dataset"), nwndDataSet)
	End Function
End Class