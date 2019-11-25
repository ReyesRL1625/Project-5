using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Project_5_Web_App
{
    public partial class Default : System.Web.UI.Page
    {
        public HttpCookie myCookies = new HttpCookie("myCookieId");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MemberButton_Click(object sender, EventArgs e)
        {
            //Requesting cookies
            myCookies = Request.Cookies["myCookiesId"];
            if ((myCookies == null) || (myCookies["Username"] == "") || (myCookies["Password"] == ""))
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                bool status = getLoginStatusMember(myCookies["Username"], myCookies["Password"]);
                if(status == false)
                {
                    Response.Redirect("Registration.aspx");
                }
                else
                    Response.Redirect("Member/Member.aspx"); // member page
            }
        }

        protected void StaffButton_Click(object sender, EventArgs e)
        {
            //Requesting cookies
            myCookies = Request.Cookies["myCookiesId"];
            if ((myCookies == null) || (myCookies["Username"] == "") || (myCookies["Password"] == ""))
            {
                Response.Redirect("StaffLogin.aspx");
            }
            else
            {
                bool status = getLoginStatusStaff(myCookies["Username"], myCookies["Password"]);
                if (status != false)
                    Response.Redirect("Protected/Staff.aspx"); // staff page
                    
            }
        }
        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void MemLoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void StaffButton_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffLogin.aspx");
        }

        protected bool getLoginStatusMember(string username, string password)
        {
            string filepath = Server.MapPath("/Member/Members.xml");
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);
            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["Username"] != null && node["Username"].InnerText == username)
                {
                    if (node["Password"] != null && node["Password"].InnerText == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        protected bool getLoginStatusStaff(string username, string password)
        {

            string filepath = Server.MapPath("/Protected/Staff.xml");
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);
            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["Username"] != null && node["Username"].InnerText == username)
                {
                    if (node["Password"] != null && node["Password"].InnerText == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

}