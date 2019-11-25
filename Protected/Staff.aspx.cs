using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;
using HashingPasswords;

namespace Project_5_Web_App.Protected
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Default.aspx");
        }

        protected void btn_addStaff(object sender, EventArgs e)
        {
            String text1 = TextBox3.Text;
            String text2 = TextBox4.Text;

            Class1 h = new Class1();
            text2 = h.hashMyPassword(text2);

            addToXml(text1, text2, "Staff.xml");
        }

        public void addToXml(string username, string password, string filePath)
        {
            string filepath = Server.MapPath(filePath);
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);
            XmlElement rootElement = myDoc.DocumentElement;
            foreach(XmlNode node in rootElement.ChildNodes)
            {
                if(node["Username"] != null && node["Username"].InnerText == username)
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

        protected void btn_rmStaff(object sender, EventArgs e)
        {

        }
    }
}