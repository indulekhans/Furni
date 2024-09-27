using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Furni
{
    public partial class productprofile : System.Web.UI.Page
    { ConnectionCls ob9 = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            string pr = "select * from productt where ProductId= " + Session["Product_Id"] + "";
            SqlDataReader dr = ob9.f_reader(pr);
            while(dr.Read())
            {
                Image1.ImageUrl = dr["ProductImage"].ToString();
                Label1.Text = dr["ProductName"].ToString();
                Label2.Text = dr["ProductPrice"].ToString();
                Label3.Text = dr["ProductDescptn"].ToString();

            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string c = "Select Max(CartId) from cartt";
            string crtid = ob9.f_scalar(c);
            int cartid = 0;
            if (crtid == "")
            {
                cartid = 1;
            }
            else
            {
                int newcid = Convert.ToInt32(crtid);
                cartid = newcid + 1;
            }
            int Totprice = Convert.ToInt32(DropDownList1.SelectedItem.Text) * Convert.ToInt32(Label2.Text);

            string ct = "insert into cartt values(" + cartid + "," + Session["uid"] + "," + Session["Product_Id"] + ",'" + DropDownList1.SelectedItem.Text + "'," + Totprice + ",'" + DateTime.Now.ToShortDateString() + "')";
            int crt = ob9.f_nonquery(ct);
            if(crt==1)
            {
                Label5.Visible = true;
                Label5.Text = "Added to cart";
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    Label6.Visible = true;
        //    Label7.Visible= true;
            Label8.Visible = true;
            int t = Convert.ToInt32(DropDownList1.SelectedItem.Text) * Convert.ToInt32(Label2.Text);
            Label7.Text = t.ToString();
            
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
   
        {
            Response.Redirect("userdetails.aspx");
        }

        
    }
}
