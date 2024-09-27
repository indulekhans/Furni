using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Furni
{
    public partial class Login : System.Web.UI.Page
    {
        ConnectionCls ob2 = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object 
            sender, EventArgs e)
        {
            string st = "select count(reg_id) from logt where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
            string cd = ob2.f_scalar(st);
            int cd1 = Convert.ToInt32(cd);
            if (cd1 == 1)
            {
                string st1 = "select reg_id from logt where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
                string regid = ob2.f_scalar(st1);
               Session["uid"] = regid;
                string st2 = "select logtype from logt where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
                string logtype = ob2.f_scalar(st2);
                if (logtype == "admin")
                {
                    
                    Response.Redirect("admindetails.aspx");
                }
                else if (logtype == "user")
                {
                    Response.Redirect("userdetails.aspx");
                }
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "Invalid username and password";
            }

            }
        }
    }
