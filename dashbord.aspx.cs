using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace schoolmanage
{
    public partial class dashbord : System.Web.UI.Page
    {
        void GetStudent()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
            string q = "proc_students_display";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
        void GetTeacher()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
            string q = "proc_teacher_display";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "teacher");
            GridView2.DataSource = ds;
            GridView2.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
           if(IsPostBack==false)
            {
                GetStudent();
                GetTeacher();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}