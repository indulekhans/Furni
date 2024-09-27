using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Furni
{
    public partial class Admin : System.Web.UI.Page
    {
        ConnectionCls ob1 = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sl = "Select Max(reg_id) from logt";
            string regid = ob1.f_scalar(sl);
            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newrid = Convert.ToInt32(regid);
                reg_id = newrid + 1;
            }

            string insadmin = "insert into admint values(" + reg_id + ",'" + TextBox7.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + ")";
            int k = ob1.f_nonquery(insadmin);
            if (k == 1)
            {
                string inslog = "insert into logt values(" + reg_id + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','admin')";
                int m = ob1.f_nonquery(inslog);

            }
        }
    }
}