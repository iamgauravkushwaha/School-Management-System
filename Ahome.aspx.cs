using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmanage
{
    public partial class Ahome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("student.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("subject.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("teacher.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("section.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Server.Transfer("dashbord.aspx");
        }
    }
}