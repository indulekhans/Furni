using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Furni
{
    public partial class editcategory : System.Web.UI.Page
    {
        ConnectionCls ob5 = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gridbind_fn();
            }

        }
        public void gridbind_fn()
        {
            string g = "select * from cat_t";
            DataSet ds = ob5.f_dataset(g);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridbind_fn();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gridbind_fn();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtnam = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            TextBox txtdesc = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            TextBox txtstat = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            FileUpload fp = (FileUpload)GridView1.Rows[i].Cells[1].FindControl("FileUpload1");
            string f = "~/Catpht/" + fp.FileName;
            fp.SaveAs(MapPath(f));
            string up = "update cat_t set CategoryName='" + txtnam.Text + "',CategoryImage='" + f + "',CategoryDescription='" + txtdesc.Text + "',CategoryStatus='" + txtstat.Text + "' where CategoryId=" + getid + "";
            int u = ob5.f_nonquery(up);
            if (u == 1)
            {
                Label1.Visible = true;
                Label1.Text = "Updated";
            }
            GridView1.EditIndex = -1;
            gridbind_fn();
        }
    }
}