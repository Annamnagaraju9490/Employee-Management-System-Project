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
    public partial class Addemp : System.Web.UI.Page
    {
        string co = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (SqlConnection cn = new SqlConnection(co))
                {
                    string qry = $"select department from department_dddt";
                    using (SqlCommand cmdd = new SqlCommand(qry, cn))
                    {
                        try
                        {
                            cn.Open();
                            SqlDataReader dc = cmdd.ExecuteReader();
                            List<string> depart = new List<string>();
                            while (dc.Read())
                            {
                                depart.Add(dc["department"].ToString());
                            }
                            dc.Close();
                            ddldept.DataSource = depart;
                            ddldept.DataBind();
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

        }

        protected void btnaddemp_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(co))
            {
                string fname = txtfname.Text;
                string lname = txtlname.Text;
                string dept = ddldept.Text;
                string email = txtemail1.Text;
                long phone = Convert.ToInt64(txtphone.Text);
                long sal = Convert.ToInt64(txtsal.Text);
                string query2 = $"insert into employee_detail values ('{fname}','{lname}',(select did from department_dddt where department='{dept}'),'{email}','{phone}','{sal}')";
                using (SqlCommand cmmd = new SqlCommand(query2, cn))
                {
                    try
                    {
                        cn.Open();
                        int res2 = cmmd.ExecuteNonQuery();
                        if (res2 == 1)
                        {
                            Response.Write("data inserted successfully");
                        }
                        else
                        {
                            Response.Write("data is not inserted");

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
    }
}