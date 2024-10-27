using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Furni
{
    public partial class viewyourBill : System.Web.UI.Page
    {
        ConnectionCls obb = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {if(!IsPostBack)
            { 
            string st1 = "select username from logt where reg_id=" + Session["uid"];
            string nam = obb.f_scalar(st1);
            Label6.Text = nam;
            string b = "select bill_id,b_date from bill_t";
            SqlDataReader dr = obb.f_reader(b);
            while(dr.Read())
            {
                Label3.Text = "f000_" + dr["Bill_Id"].ToString();
                Label2.Text = Convert.ToDateTime(dr["B_Date"]).ToString("dd/MM/yyyy");
            }
            string sumtot = "select sum(Total_Price) from ordert where UserId=" + Session["uid"] + " and status='ordered'";
                string grand_total = obb.f_scalar(sumtot);
            Label5.Text = grand_total;

            gridbind();
            }
        }
        public void gridbind()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_gridv";
            cmd.Parameters.AddWithValue("@uid", Session["uid"]);
            DataSet ds = obb.fn_adapter_stored(cmd);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ins";

            cmd.Parameters.AddWithValue("@uid", Session["uid"]);
            cmd.Parameters.AddWithValue("@acno", TextBox1.Text);
            cmd.Parameters.AddWithValue("@actype", DropDownList1.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@bal", TextBox3.Text);
            cmd.Parameters.AddWithValue("@stat","active");

            int outputval = obb.fn_nonquery_stored(cmd);

            if (outputval == 1)
            {
                Label8.Visible =  true;
                Label8.Text = "New account added";
            }
        }
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            string ac = "select count(AccTab_Id) from AccountTab where UserId=" + Session["uid"] + "";
            string cd = obb.f_scalar(ac);
            int acid = Convert.ToInt32(cd);
            if (acid > 0)
            {
                Label9.Visible = true;
                Label9.Text = "Account exists";
                Label10.Visible = true;
                NewAccountButton2.Visible = true;
                ImageButton4.Visible = true;
           }
            else
            {
                Panel1.Visible = true;
                ImageButton4.Visible = false;
            }      
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            ImageButton4.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;

        }     
    }
}

