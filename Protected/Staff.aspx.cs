using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace Project_5_Web_App.Protected
{
    public partial class Staff : System.Web.UI.Page
    {
        StaffMembers StaffMembersList = new StaffMembers();
        Members MemberList = new Members();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_addMember(object sender, EventArgs e)
        {
            String text1 = TextBox1.Text;
            String text2 = TextBox2.Text;

            var member = new List<Member>
            {
                    new Member { username = text1, password = text2 }
            };

            ToXmlFile(member, "Members.xml");
        }
        protected void btn_rmMember(object sender, EventArgs e)
        {

            String text1 = TextBox1.Text;
            String text2 = TextBox2.Text;
        }
        protected void btn_addStaff(object sender, EventArgs e)
        {
            String text1 = TextBox3.Text;
            String text2 = TextBox4.Text;
        }
        protected void btn_rmStaff(object sender, EventArgs e)
        {
            String text1 = TextBox3.Text;
            String text2 = TextBox4.Text;
        }

        public class StaffMembers
        {
            public List<Member> Member { get; set; }
        }
        public class Members
        {
            public List<Member> Member { get; set; }
        }
        public class Member
        {
            public string username { get; set; }
            public string password { get; set; }
        }
        
        public void ToXmlFile(Object obj, string filePath)
        {
            var xs = new XmlSerializer(obj.GetType());
            var ns = new XmlSerializerNamespaces();
            var ws = new XmlWriterSettings { Indent = true, OmitXmlDeclaration = true };
            ns.Add("", "");

            using (XmlWriter writer = XmlWriter.Create(Server.MapPath(filePath), ws))
            {
                xs.Serialize(writer, obj);
            }
        }
    }
}