﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Companyempproject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string co = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(co))
            {
                if (!IsPostBack)
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

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(co))
            {
                int id = Convert.ToInt32(txtid.Text);
                string qury3 = $"select e1.fname,e1.lname,d1.department,e1.email,e1.phoneno,e1.salary from employee_detail e1 join department_dddt d1 on e1.depart_id=d1.did where e1.em_id='{id}'";
                using (SqlCommand ccmd = new SqlCommand(qury3, cn))
                {
                    try
                    {
                        cn.Open();
                        SqlDataReader ddr = ccmd.ExecuteReader();
                        while (ddr.Read())
                        {
                            txtfname.Text = ddr["fname"].ToString();
                            txtlname.Text = ddr["lname"].ToString();
                            ddldept.SelectedValue = ddr["department"].ToString();
                            txtemail1.Text = ddr["email"].ToString();
                            txtphone.Text = ddr["phoneno"].ToString();
                            txtsal.Text = ddr["salary"].ToString();

                        }
                        ddr.Close();


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

        protected void btndelete_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(co))
            {
                int id = Convert.ToInt32(txtid.Text);


                string quryy = $"delete from employee_detail where em_id='{id}'";

                using (SqlCommand ccmmdd = new SqlCommand(quryy, cn))
                {


                    try
                    {
                        cn.Open();
                        int res2 = ccmmdd.ExecuteNonQuery();
                        if (res2 == 1)
                        {
                            Response.Write("<script>alert('data deleted successfully')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('data is not deleted')</script>");

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



  
