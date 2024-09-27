using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Furni
{
    public class ConnectionCls
    {
        SqlConnection con;
        SqlCommand cmd;

        public ConnectionCls()
        {
            con = new SqlConnection(@"server=DESKTOP-V9CKFFC\SQLEXPRESS;database=project1;integrated security=true");
        }

        public int f_nonquery(string sq)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sq, con);
            con.Open();
            
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
        public string f_scalar(string sq)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sq, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;

        }
        public SqlDataReader f_reader(string sq)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sq, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            return dr;

        }
        public DataSet f_dataset(string sq)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sq, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;


        }
        public DataTable fn_datatable(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataSet fn_adapter_stored(SqlCommand cmd)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    }
}