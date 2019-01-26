using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);             //Setup for the database connection for the login function.\\
            con.Open();                                                                                                                 //Opens the database.\\
            SqlCommand cmd = new SqlCommand("select * from Login where UserName =@Username and Password =@Password", con);    //Sets a search query for finding a matching Username and Password.\\
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);                                                                 //Takes the Username input for the query from the username input box.\\
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);                                                                 //Takes the password input for the query from the password input box.\\
            SqlDataAdapter da = new SqlDataAdapter(cmd);                                                                                //Defines a new data adapter for the SQL query.\\
            DataTable dt = new DataTable();                                                                                             //Defines a new DataTable.\\
            da.Fill(dt);                                                                                                                //Fills the DataTable with the Username and Password.\\
            if(dt.Rows.Count > 0)                                                                                                       //If the returned rows of the table is more than 0
            {                                                                                                                           //the login was successful.\\
                Response.Redirect("About.aspx");                                                                                      //Redirects the user to the Contact Page upon succesful login.\\
            }
            else
            {

            }
        }
    }
}