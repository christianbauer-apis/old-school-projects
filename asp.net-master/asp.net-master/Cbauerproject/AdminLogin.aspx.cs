using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System;
using System.Data;


public partial class AdminLogin : System.Web.UI.Page
{
    private string connectionString =
WebConfigurationManager.ConnectionStrings["project"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }
    protected void loginButton_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(connectionString);
        {
            con.Open();
          
            SqlCommand cmd = new SqlCommand("select * from Login where username = @username and password = @password", con);
            cmd.Parameters.AddWithValue("@username", userTextBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            
                Response.Redirect("Admin.aspx");
            

        }
       
    }
}