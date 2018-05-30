using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
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
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["restaurantConnectionString"].ConnectionString;
                using(OleDbConnection con = new OleDbConnection(cs))
                {
                    OleDbCommand cmd = new OleDbCommand("Select * from meals", con);
                    con.Open();
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("errorpage.aspx");
            }
        }
    }
}