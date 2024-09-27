using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Furni
{
    public partial class Editproduct : System.Web.UI.Page
    {
        ConnectionCls ob6 = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                Ddlist_bindcat();
                gridbind_fn();
            }

        }
        public void Ddlist_bindcat()
        {
            string slc = "select CategoryId,CategoryName from cat_t";
            DataSet ds = ob6.f_dataset(slc);
            DropDownList1.DataValueField = "CategoryId";
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataSource = ds;
            DropDownList1.DataBind();
            //DropDownList1.Items.Insert(0, "--Select--");

        }
        public void gridbind_fn()
        {
            string pdt = "select ProductId,ProductName,ProductPrice,Productstock,ProductImage,ProductDescptn,productstatus from productt where CategoryId="+DropDownList1.SelectedItem.Value+"";
            DataSet ds = ob6.f_dataset(pdt);
            
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

            TextBox txtpnam = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            TextBox txtprice = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            TextBox txtstock = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            TextBox txtdesc = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];
            TextBox txtstat = (TextBox)GridView1.Rows[i].Cells[8].Controls[0];
            FileUpload fup = (FileUpload)GridView1.Rows[i].Cells[1].FindControl("FileUpload1");
            string f = "~/Pdtpht/" + fup.FileName;
            fup.SaveAs(MapPath(f));
            string up = "update productt set ProductName='" + txtpnam.Text + "',ProductPrice=" + txtprice.Text + ",ProductStock=" + txtstock.Text + ",ProductImage='" + f + "',ProductDescptn='" + txtdesc.Text + "',ProductStatus='" + txtstat.Text + "' where ProductId=" + getid + "";

            int u = ob6.f_nonquery(up);
            if (u == 1)
            {
                Label1.Visible = true;
                Label1.Text = "Updated";
            }
            GridView1.EditIndex = -1;
            gridbind_fn();
        }

      

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridbind_fn();
        }
    }
}