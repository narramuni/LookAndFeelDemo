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
    public partial class TranferMoney : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Session["custid"].ToString();
        }

        protected void btntransfer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("server=DESKTOP-FQMV957\\SQLEXPRESS;" +
                "Integrated Security=true;database=SomeBank");
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[sp_TransferMoney]", cn))
                    {
                        cn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Input parameters
                        cmd.Parameters.AddWithValue("@p_custidFrom", Convert.ToInt32(TextBox1.Text));
                        cmd.Parameters.AddWithValue("@p_custidTo", Convert.ToInt32(txtToAccountNo.Text));
                        cmd.Parameters.AddWithValue("@p_amt", Convert.ToDecimal(txtamount.Text));

                        // Output parameter
                        SqlParameter transferStatusParam = new SqlParameter("@p_transferStatus", SqlDbType.VarChar, 50);
                        transferStatusParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(transferStatusParam);

                        // Execute the stored procedure
                        cmd.ExecuteNonQuery();

                        // Retrieve the output parameter value
                        string transferStatus = transferStatusParam.Value.ToString();

                        // Handle the transfer status as needed (display an alert, etc.)
                        Response.Write("<script>alert('" + transferStatus + "');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('An error occurred: " + ex.Message + "');</script>");
            }

            //SqlConnection cn = new SqlConnection("server=DESKTOP-FQMV957\\SQLEXPRESS;" +
            //    "Integrated Security=true;database=SomeBank");
            //SqlCommand cmd = new SqlCommand("[dbo].[sp_TransferMoney]", cn);
            //cn.Open();
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@p_custidFrom", Convert.ToInt32(TextBox1.Text));
            //cmd.Parameters.AddWithValue("@p_custidTo", Convert.ToInt32(txtToAccountNo.Text));
            //cmd.Parameters.AddWithValue("@p_amt", Convert.ToDouble(txtamount.Text));
            //cmd.ExecuteNonQuery();
            //Response.Write("<script>alert('transaction completed sucessfully...');</script>");

           
        }
    }
}