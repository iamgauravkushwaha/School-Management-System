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
    public partial class student : System.Web.UI.Page
    {
        void GetData()
        {  //Create Connection by using SwlConnection Class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
            //pass query to database by using SqlCommandCalss
            string q = "proc_display_std";
            //SqlCommand cmd = new SqlCommand(q, con);

            //Create DataAdapter Class 
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            //create object for DataSet
            DataSet ds = new DataSet();
            //fill Dataset
            da.Fill(ds, "newdonar");
            //provide Link Between GridView1 and DataSource
            GridView1.DataSource = ds;
            //Bind Data
            GridView1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                GetData();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(Session["stdid"]);
            //create connection by using SqlConnection Class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
            //Open Conection
            con.Open();

            //Pass query to database using SqlCommand class
            string q = "";
            if (Button1.Text == "Update")
            {
                q = "proc_update_stdi";
            }
            else
            {
                q = "proc_insert_std";
            }

            SqlCommand cmd = new SqlCommand(q, con);
            //informed we are using stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            //Add values to stored procedure
            if (Button1.Text == "Update")
            {
                cmd.Parameters.AddWithValue("@f",sid);
            }
            cmd.Parameters.AddWithValue("@a", TextBox2.Text);
            cmd.Parameters.AddWithValue("@b", TextBox3.Text);
            string gen1 = "";
            if (RadioButton1.Checked == true)
            {
                gen1 = RadioButton1.Text;
            }
            else
            {
                gen1 = RadioButton2.Text;
            }
            cmd.Parameters.AddWithValue("@c", gen1);
            cmd.Parameters.AddWithValue("@d", TextBox5.Text);
            cmd.Parameters.AddWithValue("@e", TextBox6.Text);
            //Execute query by using ExecuteNonQuery method
            int p = cmd.ExecuteNonQuery();
            //close connection
            con.Close();
            GetData();

            if (p != 0)
            {
                TextBox2.Text = TextBox3.Text = TextBox5.Text = TextBox6.Text = "";
                RadioButton1.Enabled = RadioButton2.Enabled = false;
                Response.Write("Record Save");
            }
            Button1.Text = "Save";

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "cmddelete")
            {
                //find index number
                int index = Convert.ToInt32(e.CommandArgument);
                //Collect rows
                GridViewRow row = GridView1.Rows[index];
                //Assign name to eid Control
                Label l2 = (Label)row.FindControl("Label2");
                //Create Connection by using SqlConnection Class
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
                //open Connection
                con.Open();
                //Pass Query to database using SqlCommand Class
                string q = "proc_delete_std";
                SqlCommand cmd = new SqlCommand(q, con);
                //inform that we are using StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;
                //Add value to Stored procedure
                cmd.Parameters.AddWithValue("@a", l2.Text);
                //Execute query by using ExecuteNonQuery()
                cmd.ExecuteNonQuery();
                //Close connection
                con.Close();
                GetData();

            }
            else if (e.CommandName == "cmdedit")
            {
                //find index number
                int index = Convert.ToInt32(e.CommandArgument);
                //Collect rows
                GridViewRow row = GridView1.Rows[index];
                //assign values to row
               // Label l1 = (Label)row.FindControl("Label1");
                Label l2 = (Label)row.FindControl("Label2");
                Label l3 = (Label)row.FindControl("Label3");
                Label l4 = (Label)row.FindControl("Label4");
                Label l5 = (Label)row.FindControl("Label5");
                Label l6 = (Label)row.FindControl("Label6");
                Label l7 = (Label)row.FindControl("Label7");
                TextBox2.Text = l3.Text;
                TextBox3.Text = l4.Text;
                if (RadioButton1.Text == l7.Text)
                {
                    RadioButton1.Enabled = true;
                }
                else
                {
                    RadioButton2.Enabled = true;
                }
                TextBox5.Text = l5.Text;
                TextBox6.Text = l6.Text;
                Button1.Text = "Update";
                Session["stdid"] = l2.Text;


                GetData();
            }
        }
    }
}