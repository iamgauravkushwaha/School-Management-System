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
    public partial class section : System.Web.UI.Page
    {
       
       void GetData()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
            string q = "proc_display_sectionin";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "sectioninfo");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        { 
            if(IsPostBack==false)
            {
                GetData();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
          

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
            con.Open();
            string q = "proc_detail_student";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@a", TextBox1.Text);
            object p =cmd.ExecuteScalar();
            con.Close();
           

            if(p!=null)
            {
                TextBox2.Text = p.ToString();
                Label2.Visible = true;
                Label2.Text = "Student Found";
              
               
            }
            else
            {
                
                Label2.Visible = true;
                Label2.Text = "Student not Found please ragister first Student Infromation";
               
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
                con.Open();
                string q = "proc_insert_sectionin";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@a", TextBox1.Text);
                cmd.Parameters.AddWithValue("@b", TextBox2.Text);
                cmd.Parameters.AddWithValue("@c", TextBox3.Text);
                cmd.Parameters.AddWithValue("@d", TextBox4.Text);
                int p = cmd.ExecuteNonQuery();


                con.Close();
                GetData();

            }
            catch(Exception)
            {
                Label2.Visible = true;
                Label2.Text = "Something Went Wrong or you are already registered";
               
            }
            finally
            {
                TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = "";
            }

            
            

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="cmddelete")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                Label l1 = (Label)row.FindControl("Label1");
                //Create Connection by using SqlConnection Class
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
                //open Connection
                con.Open();
                //Pass Query to database using SqlCommand Class
                string q = "proc_delete_sectionin";
                SqlCommand cmd = new SqlCommand(q, con);
                //inform that we are using StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;
                //Add value to Stored procedure
                cmd.Parameters.AddWithValue("@a", l1.Text);
                //Execute query by using ExecuteNonQuery()
                cmd.ExecuteNonQuery();
                //Close connection
                con.Close();
                GetData();

            }
        }
    }
}