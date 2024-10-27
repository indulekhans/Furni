using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Furni
{
    public partial class adminreply : System.Web.UI.Page
    {
        ConnectionCls obr = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                gridbind();
            }
        }
        public void gridbind()
        {
            string g = "select usert.*,feedbackt.* from usert inner join feedbackt on usert.userid=feedbackt.userid and feedbackt.fbstatus=0";
            DataSet ds = obr.f_dataset(g);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            Session["id"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("indivfbform.aspx");
        }
    }
}