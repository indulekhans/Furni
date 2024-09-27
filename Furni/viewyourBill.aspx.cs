using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Furni
{
    public partial class viewyourBill : System.Web.UI.Page
    {
        ConnectionCls obb = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            string st1 = "select username from logt where reg_id=" + Session["uid"];
            string nam = obb.f_scalar(st1);
            Label6.Text = nam;
            string b = "select bill_id,b_date from bii_t";
            SqlDataReader dr = obb.f_reader(b);
            while(dr.Read())
            {
                Label3.Text = "f000_" + dr["Bill_Id"].ToString();
                Label2.Text = dr["B_Date"].ToString();
            }
            string sumtot = "select grand_total from bill_t";
            string grand_total = obb.f_scalar(sumtot);
            Label5.Text = grand_total;

            gridbind();

        }
        public void gridbind()
        {



        }
    }
}