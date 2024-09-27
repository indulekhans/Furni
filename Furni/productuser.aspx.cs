using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Furni
{
    public partial class productuser : System.Web.UI.Page
    {
        ConnectionCls ob8= new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                string sl = "select * from productt where CategoryId="+Session["CatgryId"] +"";
                DataTable dt = ob8.fn_datatable(sl);
                DataList1.DataSource = dt;
                DataList1.DataBind();
            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            int getid = Convert.ToInt32(e.CommandArgument);
            Session["Product_Id"] = getid;
            Response.Redirect("productprofile.aspx");
        }
    }
}