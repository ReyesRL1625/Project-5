﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                String c = usernameText.Text + " " + passwordText.Text;
                //check to see if the username and password is valid and they are a member

                //Cookies
                HttpCookie myCookies = new HttpCookie("myCookieId");
                myCookies["Username"] = usernameText.Text;
                myCookies["Password"] = passwordText.Text;
                myCookies.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(myCookies);
            }
        }
    }
}