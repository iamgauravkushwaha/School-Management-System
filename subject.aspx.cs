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
    public partial class subject : System.Web.UI.Page
    {
        void GetData()
        {
            //Create Connection by using SwlConnection Class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
            //pass query to database by using SqlCommandCalss
            string q = "proc_display_subject";
            

            //Create DataAdapter Class 
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            //create object for DataSet
            DataSet ds = new DataSet();
            //fill Dataset
            da.Fill(ds, "subject");
            //provide Link Between GridView1 and DataSource
            GridView1.DataSource = ds;
            //Bind Data
            GridView1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                GetData();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GetData();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GetData();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            //Collect rows
            GridViewRow row = GridView1.Rows[e.RowIndex];
            //Assign name to eid Control
            Label l1 = (Label)row.FindControl("Label1");
            //Create Connection by using SqlConnection Class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
            //open Connection
            con.Open();
            //Pass Query to database using SqlCommand Class
            string q = "proc_delete_subject";
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

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
            //Collect rows
            GridViewRow row = GridView1.Rows[e.RowIndex];
            //Assign name to eid Control
            TextBox t1 = (TextBox)row.FindControl("TextBox1");
            TextBox t2 = (TextBox)row.FindControl("TextBox2");
            //Create Connection by using SqlConnection Class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
            //open Connection
            con.Open();
            //Pass Query to database using SqlCommand Class
            string q = "proc_edit_subject";
            SqlCommand cmd = new SqlCommand(q, con);
            //inform that we are using StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            //Add value to Stored procedure
            cmd.Parameters.AddWithValue("@a", t1.Text);
            cmd.Parameters.AddWithValue("@b", t2.Text);
            //Execute query by using ExecuteNonQuery()
            cmd.ExecuteNonQuery();
            //Close connection
            con.Close();
            GetData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(Session["stdid"]);
            //create connection by using SqlConnection Class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schl"].ToString());
            //Open Conection
            con.Open();

            //Pass query to database using SqlCommand class
            string q = "proc_insert_subject";
            SqlCommand cmd = new SqlCommand(q, con);
            //we have to inform that we are using stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            //AddedControl value to stored procedure
            cmd.Parameters.AddWithValue("@a", TextBox1.Text);
            cmd.Parameters.AddWithValue("@b", TextBox2.Text);
            //Execute query by using ExecuteNonQuery
           int p= cmd.ExecuteNonQuery();
            //close connection
            con.Close();
            GridView1.EditIndex = -1;
            GetData();

            if(p!=0)
            {
                Console.Write("record inserted");
                TextBox1.Text = TextBox2.Text = "";
            }

           

            
        }
    }
}