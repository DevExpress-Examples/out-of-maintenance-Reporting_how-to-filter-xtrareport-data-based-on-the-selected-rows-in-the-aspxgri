Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports nwndDataSetTableAdapters

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private Detail As DevExpress.XtraReports.UI.DetailBand
    Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Private xrLabel1 As XRLabel
    Private xrLabel2 As XRLabel
    Private xrLabel3 As XRLabel
    Private xrPictureBox1 As XRPictureBox
    Private DetailReport As DetailReportBand
    Private Detail1 As DetailBand
    Private xrLabel4 As XRLabel
    Private xrLabel5 As XRLabel
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        InitializeComponent()
        '
        ' TODO: Add constructor logic here
        '
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    #Region "Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "XtraReport1.resx"
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' Detail
        ' 
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrLabel3, Me.xrLabel2})
        Me.Detail.Height = 139
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' xrPictureBox1
        ' 
        Me.xrPictureBox1.Location = New System.Drawing.Point(500, 42)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.Size = New System.Drawing.Size(133, 67)
        ' 
        ' xrLabel3
        ' 
        Me.xrLabel3.Location = New System.Drawing.Point(25, 83)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel3.Size = New System.Drawing.Size(233, 25)
        Me.xrLabel3.Text = "xrLabel3"
        ' 
        ' xrLabel2
        ' 
        Me.xrLabel2.Location = New System.Drawing.Point(25, 42)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel2.Size = New System.Drawing.Size(100, 25)
        Me.xrLabel2.Text = "xrLabel2"
        ' 
        ' PageHeader
        ' 
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
        Me.PageHeader.Height = 42
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' xrLabel1
        ' 
        Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 25F)
        Me.xrLabel1.Location = New System.Drawing.Point(250, 0)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel1.Size = New System.Drawing.Size(158, 42)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.Text = "Categories"
        ' 
        ' PageFooter
        ' 
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' DetailReport
        ' 
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        ' 
        ' Detail1
        ' 
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel5, Me.xrLabel4})
        Me.Detail1.Height = 25
        Me.Detail1.Name = "Detail1"
        ' 
        ' xrLabel5
        ' 
        Me.xrLabel5.Location = New System.Drawing.Point(383, 0)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel5.Size = New System.Drawing.Size(108, 25)
        Me.xrLabel5.Text = "xrLabel5"
        ' 
        ' xrLabel4
        ' 
        Me.xrLabel4.Location = New System.Drawing.Point(125, 0)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel4.Size = New System.Drawing.Size(175, 25)
        Me.xrLabel4.Text = "xrLabel4"
        ' 
        ' XtraReport1
        ' 
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter, Me.DetailReport})
        Me.Version = "8.2"
        DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    #End Region

    Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        DataMember = "Categories"
        DetailReport.DataMember = "Categories.CategoriesProducts"

        xrLabel2.DataBindings.Add("Text", Nothing, "Categories.CategoryName")
        xrLabel3.DataBindings.Add("Text", Nothing, "Categories.Description")
        xrPictureBox1.DataBindings.Add("Image", Nothing, "Ctegories.Picture")

        xrLabel4.DataBindings.Add("Text", Nothing, "Categories.CategoriesProducts.ProductName")
        xrLabel5.DataBindings.Add("Text", Nothing, "Categories.CategoriesProducts.UnitPrice")
    End Sub
End Class
