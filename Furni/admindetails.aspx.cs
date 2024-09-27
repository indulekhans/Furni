using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Furni
{
    public partial class admindetails : System.Web.UI.Page
    {
        ConnectionCls ob3 = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            string st1 = "select username from logt where reg_id="+Session["uid"] ;
            string nam = ob3.f_scalar(st1);
            Label6.Visible = true;
            Label6.Text = nam;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("addcategory.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Addproduct.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("editcategory.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Editproduct.aspx");
        }
    }
}