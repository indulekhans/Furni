using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Furni
{
    public partial class User : System.Web.UI.Page
    {
        ConnectionCls ob = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
               Ddlist_bindstate();
                Ddlist_binddisrict();


            }

        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sl = "Select Max(reg_id) from logt";
            string regid = ob.f_scalar(sl);
            int rid = 0;
            if(regid=="")
            {
                rid = 1;
            }
            else
            {
                int newrid = Convert.ToInt32(regid);
                rid = newrid + 1;
            }

            string insuser = "insert into usert values(" + rid + ",'" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + ",'" + TextBox4.Text + "'," + TextBox5.Text + ",'" + DropDownList2.SelectedItem.Text + "','" + DropDownList1.SelectedItem.Text + "','active')";
            int k = ob.f_nonquery(insuser);
            if(k==1)
            {
                string inslog = "insert into logt values(" + rid + ",'" + TextBox8.Text + "','" + TextBox9.Text + "','user')";
                int m = ob.f_nonquery(inslog);

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from districttab where state='" + DropDownList1.SelectedItem.Text + "'";
            DataSet ds = ob.f_dataset(str);
            DropDownList2.DataValueField = "Id";
            DropDownList2.DataTextField = "District_name";
            DropDownList2.DataSource = ds;
            DropDownList2.DataBind();

        }
        public void Ddlist_bindstate()
        {
            string sl = "Select Id,State_name from statetab";
            DataSet ds = ob.f_dataset(sl);
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataTextField = "State_name";
            DropDownList1.DataSource = ds;
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--Select--");

        }
        public void Ddlist_binddisrict()
        {
            string s = "Select Id,District_name from districttab where state='" + DropDownList1.SelectedItem.Text + "'";
            DataSet ds = ob.f_dataset(s);
            DropDownList2.DataValueField = "Id";
            DropDownList2.DataTextField = "District_name";
            DropDownList2.DataSource = ds;
            DropDownList2.DataBind();
            DropDownList1.Items.Insert(0, "--Select--");




        }
    }
}