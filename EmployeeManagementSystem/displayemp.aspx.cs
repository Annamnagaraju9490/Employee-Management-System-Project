using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementSystem
{
    public partial class displayemp : System.Web.UI.Page
    {
        string co = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(co))
            {
                if (!IsPostBack)
                {


                    string query5 = $"select e1.fname,e1.lname,d1.department,e1.email,e1.phoneno,e1.salary from employee_detail e1 join department_dddt d1 on e1.depart_id=d1.did";
                    using (SqlCommand cmmdd = new SqlCommand(query5, cn))
                    {
                        List<Employee> lstemp = new List<Employee>();
                        try
                        {
                            cn.Open();
                            SqlDataReader ddr = cmmdd.ExecuteReader();
                            while (ddr.Read())
                            {
                                Employee e1 = new Employee();
                                e1.fname = ddr["fname"].ToString();
                                e1.lname = ddr["lname"].ToString();
                                e1.department = ddr["department"].ToString();
                                e1.email = ddr["email"].ToString();
                                e1.phoneno = ddr["phoneno"].ToString();
                                e1.salary = ddr["salary"].ToString();
                                lstemp.Add(e1);
                            }
                            ddr.Close();
                            grddis.DataSource = lstemp;
                            grddis.DataBind();
                        }
                        catch (SqlException ex)
                        {
                            Response.Write(ex.Message);
                        }
                        catch
                        {
                            
                        }
                    }
                }
            }


        }

        
    }
    public class Employee
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string department { get; set; }
        public string email { get; set; }
        public string phoneno { get; set; }
        public string salary { get; set; }
    }
}