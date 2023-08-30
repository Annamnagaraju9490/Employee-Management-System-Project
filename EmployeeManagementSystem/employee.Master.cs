using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementSystem
{
    public partial class employee : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void lnkaddemp_Click(object sender, EventArgs e)
        {
            Response.Redirect("addeployees.aspx");
        }

        protected void lnkupdateemp_Click(object sender, EventArgs e)
        {
            Response.Redirect("updateemployee.aspx");
        }

        protected void lnkdis_Click(object sender, EventArgs e)
        {
            Response.Redirect("displayemp.aspx");
        }

        protected void logout_Click(object sender, EventArgs e)
        {

        }

        protected void lnkhomepage_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }
    }
}