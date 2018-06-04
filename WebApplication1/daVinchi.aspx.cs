using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class daVinchi : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //string cs = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);
            //SqlCommand cmd = new SqlCommand("SELECT Ore FROM Table", con);
            //con.Open();
            //GridView1.DataSource = cmd.ExecuteReader();
            //GridView1.DataBind();
            //con.Close();
        }
    }
}