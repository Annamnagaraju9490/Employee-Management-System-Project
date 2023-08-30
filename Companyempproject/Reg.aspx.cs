using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Companyempproject
{
    public partial class Reg : System.Web.UI.Page
    {
        string co = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(co))
            {
                string ename = txtename.Text;
                string pswd = txtpassword.Text;
                long phno = Convert.ToInt64(txtphno.Text);
                string email = txtemail.Text;
                string query1 = $"insert into registrationform values('{ename}','{pswd}','{phno}','{email}')";
                using (SqlCommand cmd = new SqlCommand(query1, cn))
                {
                    try
                    {
                        cn.Open();
                        int res = cmd.ExecuteNonQuery();
                        if (res == 1)
                        {
                            Response.Redirect("data inserted successfully");
                        }
                        else
                        {
                            Response.Redirect("data is not inserted");
                        }
                    }
                    catch (SqlException ex)
                    {
                        Response.Redirect(ex.Message);
                    }
                    finally
                    {
                        if (cn.State == System.Data.ConnectionState.Open)
                            cn.Close();
                    }

                }
            }

        }

        protected void lnkgotologin_Click(object sender, EventArgs e)
        {
            Response.Redirect("lgin.aspx");
        }
    }
}