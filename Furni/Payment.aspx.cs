using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Furni
{
    public partial class Payment : System.Web.UI.Page
    {
        ConnectionCls obp = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)

            {

           
            string sb1 = "select Grand_total from bill_t where Userid=" + Session["uid"] + " and B_Status='ordered ' and Bill_Id in(select max(Bill_Id) from bill_t) ";
            Session["bilamt"] = Convert.ToInt32(obp.f_scalar(sb1));
            Label5.Text = Session["bilamt"].ToString();
                
                Label6.Visible = false;
                Label9.Visible = false;
            Ddlist_acno();
            }
        }
        public void Ddlist_acno()
        {
            string sla = "select AccTab_Id,acc_no from accountTab where userid=" + Session["uid"] + " ";
            DataSet ds = obp.f_dataset(sla);
            DropDownList1.DataValueField = "AccTab_Id";
            DropDownList1.DataTextField = "acc_no";
            DropDownList1.DataSource = ds;
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--Select--");

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            balamt_services.ServiceClient objt = new balamt_services.ServiceClient();
            
            long balamt = objt.balancecheck(Convert.ToInt32(DropDownList1.SelectedItem.Text));
            int billamt = Convert.ToInt32(Session["bilamt"]);
            Session["actno"] = Convert.ToInt32(DropDownList1.SelectedItem.Text);
            if (balamt >= billamt)
            {
                long newbal = balamt - billamt;
                string upac = "update accounttab set balance_amt=" + newbal + " where acc_no="+ Session["actno"] + " and  userid=" + Session["uid"]+"";
                int k = obp.f_nonquery(upac);
                if(k==1)
                {
                    string upos = "update ordert set status='Paid' where userid=" + Session["uid"]+ " and status='ordered'"; 
                    obp.f_nonquery(upos);
                    string upbs = "update bill_t set b_status='Paid' where userid=" + Session["uid"] + " and b_status='ordered'"; 
                    obp.f_nonquery(upbs);

                    string pid= "select productid from ordert where status='Paid' and userid=" + Session["uid"] + "";
                    SqlDataReader dr = obp.f_reader(pid);
                    List<int> pdtid = new List<int>();
                    while (dr.Read())
                    {
                        pdtid.Add(Convert.ToInt32(dr["ProductId"]));
                    }
                    foreach(int i in pdtid)
                    {
                        string s = "select productt.Productstock,ordert.quantity from productt inner join ordert on ordert.ProductId="+i+" and userid=" + Session["uid"] + "";
                        SqlDataReader drp = obp.f_reader(s);
                        int oldstock = 0;
                        int qty = 0;
                        while(drp.Read())
                        {
                            oldstock = Convert.ToInt32(drp["ProductStock"]);
                            qty= Convert.ToInt32(drp["Quantity"]);
                        }
                        int newstk = oldstock - qty;
                        string upqty = "update productt set productstock=" + newstk + " where productid=" + i + "";
                        int uq=obp.f_nonquery(upqty);
                        if(uq==1)
                        {
                            Label8.Visible = true;
                            Label8.Text = "Successfully Paid";
                            ImageButton2.Visible = true;
                        }

                    }
                }
            }
            else
            {
              Panel1.Visible = true;
                Label3.Text = "Insufficient balance";
                ImageButton1.Visible = false;
                string updt1 = "update ordert set status='Failed' where userid=" + Session["uid"] + " and status='ordered'"; 
                obp.f_nonquery(updt1);
                string updt2= "update bill_t set b_status='Failed' where userid=" + Session["uid"] + " and b_status='ordered'";
                obp.f_nonquery(updt2);

            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string updact= "update accountTab set Balance_Amt ="+TextBox1.Text+ " where Acc_No=" + Session["actno"] + "";
            int a=obp.f_nonquery(updact);
            //string r = Session["bilamt"].ToString();
            //RangeValidator1.MinimumValue = r;
            if(a==1)
            {
                Label7.Visible = true;
                
                ImageButton2.Visible = true;

            }
            
        }
    }
}