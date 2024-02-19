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
    public partial class teacher : System.Web.UI.Page
    {
        void GetData()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
            string q = "proc_display_teacher";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "teacher");
            GridView1.DataSource = ds;
            GridView1.DataBind();


        }
        void GetSubject()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
            string q = "proc_display_subject";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "subject");
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "subname";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--select--");


        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                GetSubject();
                GetData();
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
            con.Open();
            string q = "";
            if(Button1.Text=="Update")
            {
                q = "proc_edit_teacher";
                

            }
            else
            {
                q = "proc_insert_teacher";
            }
            
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@a", TextBox1.Text);
            cmd.Parameters.AddWithValue("@b", TextBox2.Text);
            cmd.Parameters.AddWithValue("@c", DropDownList1.SelectedItem.Text);
            string gen = "";
            if(RadioButton1.Checked==true)
            {
                gen = "male";
            }
            else
            {
                gen = "female";
            }
            cmd.Parameters.AddWithValue("@d", gen);
            cmd.Parameters.AddWithValue("@e", TextBox3.Text);
            cmd.Parameters.AddWithValue("@f", TextBox4.Text);
            cmd.Parameters.AddWithValue("@g", TextBox5.Text);
            int p=cmd.ExecuteNonQuery();
            con.Close();
           // GetData();
           // GetSubject();
           
            if(p!=0)
            {
                Button1.Text = "Save";
                TextBox1.Enabled = true;
                Console.WriteLine("record inserted");
                TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = "";
                RadioButton1.Checked = RadioButton2.Checked = false;
                DropDownList1.Items.Clear();
                GetSubject();
                GetData();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdDelete")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                Label l1 = (Label)row.FindControl("Label1");
                //Create Connection by using SqlConnection Class
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
                //open Connection
                con.Open();
                //Pass Query to database using SqlCommand Class
                string q = "proc_delete_teacher";
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
            else if (e.CommandName == "cmdEdit")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                Label t1 = (Label)row.FindControl("Label1");
                Label t2 = (Label)row.FindControl("Label2");
                Label t3 = (Label)row.FindControl("Label3");
                Label t4 = (Label)row.FindControl("Label4");
                Label t5 = (Label)row.FindControl("Label5");
                Label t6 = (Label)row.FindControl("Label6");
                Label t7 = (Label)row.FindControl("Label7");

                TextBox1.Text = t1.Text;
                TextBox2.Text = t2.Text;
                DropDownList1.SelectedItem.Text = t3.Text;
                if (t4.Text == "male")
                {
                    RadioButton1.Checked = true;
                }
                else
                {
                    RadioButton2.Checked= true;
                }
                TextBox3.Text = t5.Text;
                TextBox4.Text = t7.Text;
                TextBox5.Text = t6.Text;
                Button1.Text = "Update";
                TextBox1.Enabled = false;

            }
        }
    }
}