using System;
using DevExpress.Web.ASPxGridView;
using nwndDataSetTableAdapters;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        nwndDataSet ds = GetData();

        ASPxGridView1.DataSource = ds;
        ASPxGridView1.DataMember = ds.Categories.TableName;

        ASPxGridView1.DataBind();

        XtraReport1 report = GetReport();
        string selectedIDs = HiddenField1.Value.Trim(new char[] { ',' });

        report.FilterString = string.Format("CategoryID in ({0})", selectedIDs);
        report.CreateDocument();
        ReportViewer1.Report = report;
    }

    protected void ReportViewer1_Unload(object sender, EventArgs e) {
        ReportViewer1.Report = null;
    }

    protected XtraReport1 GetReport() {
        if ((XtraReport1)Session["report"] == null) {
            XtraReport1 report = new XtraReport1();
            report.DataSource = GetData();

            Session["report"] = report;
        }

        return (XtraReport1)Session["report"];
    }

    protected nwndDataSet GetData() {
        if ((nwndDataSet)Session["dataset"] == null) {
            nwndDataSet ds = new nwndDataSet();
            CategoriesTableAdapter cta = new CategoriesTableAdapter();
            ProductsTableAdapter pta = new ProductsTableAdapter();

            cta.Fill(ds.Categories);
            pta.Fill(ds.Products);

            Session["dataset"] = ds;
        }

        return (nwndDataSet)Session["dataset"];
    }
}