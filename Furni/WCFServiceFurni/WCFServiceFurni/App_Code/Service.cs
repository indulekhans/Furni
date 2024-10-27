using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	SqlConnection con = new SqlConnection(@"server=DESKTOP-V9CKFFC\SQLEXPRESS;database=project1;integrated security=true");
	public long balancecheck(int accno)
    {
		long bal = 0;
		string sbl= "select Balance_Amt from AccountTab where Acc_No ="+ accno + "";
		SqlCommand cmd = new SqlCommand(sbl, con);
		con.Open();
		SqlDataReader dr = cmd.ExecuteReader();
		while(dr.Read())
        {
			bal = Convert.ToInt64(dr["Balance_Amt"]);
        }
		con.Close();
		return bal;



	}

	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
