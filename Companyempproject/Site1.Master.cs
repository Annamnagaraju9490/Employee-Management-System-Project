using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Companyempproject
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkhomepage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Hm.aspx");
        }

        protected void lnkaddemp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Addemp.aspx");
        }

       // protected void lnkdis_Click(object sender, EventArgs e)
       // {
       //     Response.Redirect("dis.aspx");
       // }

        protected void lnkupdateemp_Click(object sender, EventArgs e)
        {
            Response.Redirect("updat.aspx");
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("lgin.aspx");
        }

        protected void lkdis_Click(object sender, EventArgs e)
        {
            Response.Redirect("display.aspx");
        }

        protected void lnkdelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("delete1.aspx");
        }

        //protected void lnkdis_Click1(object sender, EventArgs e)
        //{
        //    Response.Redirect("dis.aspx");
        // }

        //protected void lnkdis_Click(object sender, EventArgs e)
        // {
        //      Response.Redirect("dis.aspx");
        // }
    }
}