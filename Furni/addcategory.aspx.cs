using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Furni
{
    public partial class addcategory : System.Web.UI.Page
    {
        ConnectionCls ob3 = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "~/Catpht/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(s));
            string si = "insert into cat_t values('" + TextBox1.Text + "','" + s + "','" + TextBox2.Text + "','available')";
            int m = ob3.f_nonquery(si);
            if (m == 1)
            {
                Label2.Visible = true;

                Label2.Text = "New Category Inserted Successfully";
            }
        }
    }
}