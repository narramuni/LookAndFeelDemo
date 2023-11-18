using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LookAndFeelDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("server=DESKTOP-FQMV957\\SQLEXPRESS;" +
                "Integrated Security=true;database=SomeBank");
            SqlCommand cmd = new SqlCommand("[dbo].[ValidateUser]", cn);
            cn.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_username", Convert.ToInt32(txtuserid.Text));
            cmd.Parameters.AddWithValue("@p_pwd", txtpwd.Text);

            cmd.Parameters.Add("@p_userStatus", System.Data.SqlDbType.VarChar, 7);
            cmd.Parameters["@p_userStatus"].Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add("@p_custname", System.Data.SqlDbType.VarChar, 50);
            cmd.Parameters["@p_custname"].Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            string status = cmd.Parameters["@p_userStatus"].Value.ToString();
            if (status == "Valid")
            {
                Session["username"] = cmd.Parameters["@p_custname"].Value.ToString();
                Session["custid"] = Convert.ToInt32(txtuserid.Text);
                //   Response.Write("User valid and username= "+ Session["username"].ToString());
                Response.Redirect("~/ViewBalance.aspx");
            }
            else
            {
                Response.Write("Invalid USerid/password...");
            }
            cn.Close();
        }
    }
}