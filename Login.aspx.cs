using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.UI;
using System.Web.UI.WebControls;
using HashingPasswords;
using System.Xml;

namespace Project_5_Web_App
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            //if the username and password are not empty
            if ((usernameText.Text != "") && (passwordText.Text != ""))
            {
                //get the text
                string username = usernameText.Text;
                string password = passwordText.Text;

                //creates a new class
                Class1 h = new Class1();
                //encrypts the password
                password = h.hashMyPassword(password);

                //checks if they are a member
                bool loginSuccess = getLoginStatus(username, password);

                if (loginSuccess)
                {
                    //Creates a new cookie
                    HttpCookie myCookies = new HttpCookie("myCookieId");
                    //stores the username and password
                    myCookies["Username"] = username;
                    myCookies["Password"] = password;
                    //sets expiration for 1 day
                    myCookies.Expires = DateTime.Now.AddDays(1);
                    //adds the cookie into the collection of cookies
                    Response.Cookies.Add(myCookies);
                    if(Request.Cookies != null)
                    {
                        bool help = true;
                    }

                    //redirects the page to member page
                    Response.Redirect("/Member/Member.aspx");
                }
                else
                {
                    //prints that there is an invalid login
                    errorUser.Text = String.Format("Invalid login");
                    //displays the error
                    errorUser.Visible = true;
                }
            }
        }
        protected bool getLoginStatus(string username, string password)
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
    }
}