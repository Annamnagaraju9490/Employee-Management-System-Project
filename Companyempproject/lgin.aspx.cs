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
    public partial class lgin : System.Web.UI.Page
    {
        string co = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(co))
            {
                string username = txtname.Text;
                string password = txtpswd.Text;
                string query2 = $"select * from registrationform where ename='{username}' and password='{password}'";
                using (SqlCommand cmd1 = new SqlCommand(query2, cn))
                {
                    try
                    {
                        cn.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows)
                        {
                            Response.Redirect("Hm.aspx");
                        }
                        else
                        {
                            Response.Write("<h3 align='center' style='color:red'>data is not present<h3>");
                        }

                    }
                    catch (SqlException ex)
                    {
                        Response.Write(ex.Message);
                    }
                    finally
                    {
                        if (cn.State == System.Data.ConnectionState.Open)
                            cn.Close();
                    }
                }

            }

        }

        protected void lnksignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reg.aspx");
        }
    }
}