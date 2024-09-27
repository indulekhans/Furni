using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Furni
{
    public partial class viewcart : System.Web.UI.Page
    {
        ConnectionCls ob10 = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {if (!IsPostBack)
            {
                gridbind_fn();
            }
            string csum = "select sum(Total_Price) from cartt where UserId="+Session["uid"]+"";
            int su = Convert.ToInt32(ob10.f_scalar(csum));
            Label3.Text = su.ToString();
            


        }
        public void gridbind_fn()
        {
            string gb = " select productt.ProductId,productt.ProductImage,productt.ProductName,productt.ProductPrice,cartt.ProductId,cartt.ProductQuantity,cartt.Total_Price from productt INNER JOIN cartt on productt.ProductId=cartt.ProductId AND cartt.UserId="+Session["uid"]+"";
            DataSet ds = ob10.f_dataset(gb);
            GridView1.DataSource = ds;
            GridView1.DataBind(); 
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {


            List<int> crtid = new List<int>();
            string ccid = "select cartid from cartt where UserId=" + Session["uid"] + "";
            SqlDataReader dr = ob10.f_reader(ccid);
            while(dr.Read())
            {
                crtid.Add(Convert.ToInt32(dr["CartId"]));
            }
           

            foreach(int i in crtid)
            {
                string al = "select * from cartt where cartid=" + i + "";
                SqlDataReader drc = ob10.f_reader(al);
             
                int pid = 0;

                int qty = 0;
                int totprice = 0;
                while(drc.Read())
                {
                    pid = Convert.ToInt32(drc["ProductId"]);
                    qty =Convert.ToInt32( drc["ProductQuantity"]);
                    totprice = Convert.ToInt32(drc["Total_Price"]);

                }
                string ins = "insert into ordert values(" + pid + "," + Session["uid"] + " ," + qty + "," + totprice + ",'" + DateTime.Now.ToShortDateString() + "','oredered')";
                ob10.f_nonquery(ins);
                string delc = "delete from cartt where ProductId=pid AND UserId=" + Session["uid"] + "";
                ob10.f_nonquery(delc);

            }
            string sumtot = "select sum(Total_Price)from ordert";
            int grand_total = Convert.ToInt32(ob10.f_scalar(sumtot));
            string sbill= "insert into bill_t values(" + Session["uid"] + ","+grand_total+",'" + DateTime.Now.ToShortDateString() + "')";
            ob10.f_nonquery(sbill);
            Response.Redirect("viewyourBill.aspx");


        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[3].Visible = false;
            e.Row.Cells[4].Visible = false;
            e.Row.Cells[7].Visible = false;

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
            string pr = "select ProductPrice from productt where ProductId=" + getid + ""; 
            string pp = ob10.f_scalar(pr);
            Session["price"] = pp;

            TextBox txtqty = (TextBox)GridView1.Rows[i].Cells[8].Controls[0];

            int k = Convert.ToInt32(txtqty.Text) *Convert.ToInt32(Session["price"]) ;
            string tp = k.ToString();
            
            string updt = "update cartt set ProductQuantity =" + txtqty.Text + ",Total_Price='"+tp+"' where ProductId=" + getid + "";
            
            ob10.f_nonquery(updt);
            gridbind_fn();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string cdel = "delete from cartt where ProductId=" + getid + "";
            ob10.f_nonquery(cdel);
            gridbind_fn();
        }
    }
}