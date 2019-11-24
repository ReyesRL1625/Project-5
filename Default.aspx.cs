using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_5_Web_App
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnCamp_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://neptune.fulton.ad.asu.edu/roboticscamp/");
        }
        protected void btnStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("Protected/Staff.aspx"); // staff page
        }
        protected void btnStaffLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx"); // Staff login page
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Account/StudentRegister.aspx");
        }
        protected void btnStudentLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Account/StudentLogin.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }

}