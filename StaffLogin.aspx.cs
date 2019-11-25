using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using HashingPasswords;

namespace Project_5_Web_App
{
    public partial class StaffLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if ((usernameText.Text != "") && (passwordText.Text != ""))
            { 
                String username = usernameText.Text;
                String password = passwordText.Text;

                Class1 h = new Class1();
                password = h.hashMyPassword(password);

                bool loginSuccess = getLoginStatus(username, password);

                if (loginSuccess)
                {
                    //Cookies
                    HttpCookie myCookies = new HttpCookie("myCookieId");
                    myCookies["Username"] = usernameText.Text;
                    myCookies["Password"] = passwordText.Text;
                    myCookies.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(myCookies);

                    Response.Redirect("/Protected/Staff.aspx");
                } else
                {
                    errorUser.Text = String.Format("Invalid login");
                    errorUser.Visible = true;
                }
            }
        }

        protected bool getLoginStatus(string username, string password)
        {

            string filepath = Server.MapPath("/Protected/Staff.xml");
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);
            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["Username"] != null && node["Username"].InnerText == username)
                {
                    if(node["Password"] != null && node["Password"].InnerText == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}