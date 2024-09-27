
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Furni
{
    public partial class Addproduct : System.Web.UI.Page
    {
        ConnectionCls ob4 = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Ddlist_bindcat();

            }

        }
        public void Ddlist_bindcat()
        {
            string slc = "select CategoryId,CategoryName from cat_t";
            DataSet ds = ob4.f_dataset(slc);
            DropDownList1.DataValueField = "CategoryId";
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataSource = ds;
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--Select--");

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Pdtpht/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string sp = "insert into productt values(" + DropDownList1.SelectedItem.Value + ",'" + TextBox1.Text + "'," + TextBox2.Text + "," + TextBox3.Text + ",'" + p + "','" + TextBox4.Text + "','available')";
            int m = ob4.f_nonquery(sp);
            if (m == 1)
            {
                Label1.Visible = true;
                Label1.Text = "New Product Inserted Successfully";
            }
        }
    }
}