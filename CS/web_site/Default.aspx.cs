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
    }
    protected void ASPxGridView1_BeforeGetCallbackResult(object sender, EventArgs e) {
        if (!gridView.IsEditing && !gridView.IsNewRowEditing) {
            gridView.AddNewRow();
        }
    }
}
