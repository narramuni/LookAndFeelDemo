using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LookAndFeelDemo
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("server=DESKTOP-FQMV957\\SQLEXPRESS;" +
                "Integrated Security=true;database=SomeBank");
            SqlCommand cmd = new SqlCommand("select * from [dbo].[fn_ShowTransactionHistory](@p_custid)", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@p_custid", Convert.ToInt32(txtcustid.Text));
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            cn.Close();
        }
    }
}