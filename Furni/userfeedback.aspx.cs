using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Furni
{
    public partial class userfeedback : System.Web.UI.Page
    {
        ConnectionCls obf = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string f = "insert into feedbackt values(" + Session["uid"] + ",'" + TextBox1.Text + "',' ',0)";
            int fb = obf.f_nonquery(f);
            if(fb==1)
            {
                Label3.Visible = true;
                Label3.Text = "Thank You for your valuable feedback";
            }
        }
    }
}