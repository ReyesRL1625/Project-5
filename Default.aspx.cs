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
      

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MemberButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member/Member.aspx"); // member page
        }

        protected void StaffButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Protected/Staff.aspx"); // staff page
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void MemLoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void StaffLoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffLogin.aspx");
        }
    }

}