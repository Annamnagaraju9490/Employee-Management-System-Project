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
    public partial class dis : System.Web.UI.Page
    {
        string co = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(co))
            {
                if (!IsPostBack)
                {


                    string query5 = $"select e1.em_id,e1.fname,e1.lname,d1.department,e1.email,e1.phoneno,e1.salary from employee_detail e1 join department_dddt d1 on e1.depart_id=d1.did";
                    using (SqlCommand cmmdd = new SqlCommand(query5, cn))
                    {
                        List<Employee> lstemp = new List<Employee>();
                        try
                        {
                            cn.Open();
                            SqlDataReader ddr = cmmdd.ExecuteReader();
                            while (ddr.Read())
                            {
                                int eid = Convert.ToInt32(ddr["em_id"].ToString());
                                string fname = ddr["fname"].ToString();
                                 string lname = ddr["lname"].ToString();
                               string department = ddr["department"].ToString();
                                string email = ddr["email"].ToString();
                                long phoneno = Convert.ToInt64( ddr["phoneno"].ToString());
                                long salary = Convert.ToInt64( ddr["salary"].ToString());
                                Employee e1 = new Employee(eid,fname, lname,department,email,phoneno,salary);
                                lstemp.Add(e1);
                            }

                            employeeGridView.DataSource = lstemp;
                            employeeGridView.DataBind();
                            
                          
                        }
                        catch (SqlException ex)
                        {
                            Response.Write(ex.Message);
                        }
                        finally
                        {
                          //  if (cn.State == System.Data.ConnectionState.open)
                            //    cn.Close();
                        }
                    }
                }
            }

        }
        public class Employee
        {
            public int em_id { get; set; }
            public string fname { get; set; }
            public string lname { get; set; }
            public string department { get; set; }
            public string email { get; set; }
            public long phoneno { get; set; }
            public long salary { get; set; }
            public Employee(int eid,string fname,string lname,string department, string email,long phoneno,long salary)
            {
                this.em_id = eid;
                this.fname = fname;
                this.lname = lname;
                this.department = department;
                this.email = email;
                this.phoneno = phoneno;
                this.salary = salary;
            }
        }

        protected void employeeGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
   
}