using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Furni
{
    public partial class adminbilldetails : System.Web.UI.Page
    {
        ConnectionCls o = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {if(!IsPostBack)
            {
                bill_gridbind();
            }
            
        }
        public void bill_gridbind()
        {
            string bsel = "select * from bill_t where b_status='Paid'";
            DataSet ds = o.f_dataset(bsel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        

        protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            bill_gridbind();
        }

        protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            bill_gridbind();
        }

        protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox texstat = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            string ups = "update bill_t set b_status='" + texstat.Text + "' where bill_Id="+getid+"";
            int st=o.f_nonquery(ups);
            if(st==1)
            {
                Label1.Visible = true;
                Label1.Text = "Status updated";
            }
            GridView1.EditIndex = -1;
            bill_gridbind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[4].Visible = false;
        }
    }
}
