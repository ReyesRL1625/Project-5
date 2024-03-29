﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using HashingPasswords;

namespace Project_5_Web_App
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "~/imageProcess.aspx";
        }

        protected void btn_addUser(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;
            string passwordConf = TextBox3.Text;

            if(password != passwordConf)
            {
                errorUser.Text = String.Format("Passwords must match");
                return;
            }
            if (!Session["generatedString"].Equals(TextBox4.Text))
            {
                errorUser.Text = String.Format("Wrong captcha string, try again!");
                return;
            }

            Class1 h = new Class1();
            password = h.hashMyPassword(password);

            addToXml(username, password, "/Member/Members.xml");
        }

        public void addToXml(string username, string password, string filePath)
        {
            string filepath = Server.MapPath(filePath);
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);
            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["Username"] != null && node["Username"].InnerText == username)
                {
                    errorUser.Text = String.Format("Username already exists");
                    errorUser.Visible = true;
                    return;
                }
            }

            XmlElement newMember = myDoc.CreateElement("Member", rootElement.NamespaceURI);
            rootElement.AppendChild(newMember);
            XmlElement newUser = myDoc.CreateElement("Username", rootElement.NamespaceURI);
            newMember.AppendChild(newUser);
            newUser.InnerText = username;

            XmlElement newPass = myDoc.CreateElement("Password", rootElement.NamespaceURI);
            newMember.AppendChild(newPass);
            newPass.InnerText = password;

            myDoc.Save(filepath);

            errorUser.Text = String.Format("User created");
        }


        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void NewImageButton_Click(object sender, EventArgs e)
        {
            MyImageService.ServiceClient fromService = new MyImageService.ServiceClient(); // create proxy to the remote service 
            string length = "4";
            Session["userLength"] = length;
            string myStr = fromService.GetVerifierString(length);
            Session["generatedString"] = myStr;
            Image1.Visible = true;
        }
    }
}