using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            gridView.AddNewRow();
        }
		DisableUpdateInDemo();
    }
    protected void ASPxGridView1_BeforeGetCallbackResult(object sender, EventArgs e) {
        if (!gridView.IsEditing && !gridView.IsNewRowEditing) {
            gridView.AddNewRow();
        }
    }
	protected void gridView_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e) {

	}
	protected void gridView_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e) {

	}


	//Database update is not allowed in online demos
	private void DisableUpdateInDemo() {
		AccessDataSource1.Updating += AccessDataSource1_Cancel;
		AccessDataSource1.Inserting += AccessDataSource1_Cancel;
		AccessDataSource1.Deleting += AccessDataSource1_Cancel;
	}

	void AccessDataSource1_Cancel(object sender, SqlDataSourceCommandEventArgs e) {
		e.Cancel = true;
	}
}
