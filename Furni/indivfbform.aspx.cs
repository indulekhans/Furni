using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;

namespace Furni
{
    public partial class indivfbform : System.Web.UI.Page
    {
        ConnectionCls obm = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            string m = "select email from usert where UserId=" + Session["id"] + "";
            string s=obm.f_scalar(m);
            Session["eml"] = s;
            TextBox1.Text = s;
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            string to = TextBox1.Text;
            string sub = TextBox2.Text;
            string rep = TextBox3.Text;
            SendEmail2("aditya", "furniaditya2024@gmail.com", "kxak gcoh fdut rjvg", "aditya anand", to, sub, rep);
            string upf = "update feedbackt set reply_msg='" + TextBox3.Text + "',fbstatus=1 where UserId=" + Session["id"] + " ";
            int f = obm.f_nonquery(upf);
            if(f==1)
            {
                Label5.Visible = true;
                Label5.Text = "Message sent to customer";
            }
        }
        public static void SendEmail2(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)

        {
            string to = toEmail; //To address    
            string from = yourGmailUserName; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = body;
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(yourGmailUserName, yourGmailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}