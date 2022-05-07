using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;

public partial class Order : System.Web.UI.Page
{

    private string connectionString =
 WebConfigurationManager.ConnectionStrings["project"].ConnectionString;


    protected void Page_Load(object sender, EventArgs e)
    {
      

        string comp="N/A";
        string lap="N/A";
        string fone="N/A";
        int totalCharge=0;

        if (Session["TotalCharges"] != null)
        { totalCharge = Convert.ToInt32(Session["TotalCharges"]); }

        if (Session["comp"] != null)
        { comp = (string)(Session["comp"]); }
        else
            (Session["comp"]) = comp;

        if (Session["lap"] != null)
        { lap = (string)(Session["lap"]); }
        else
            (Session["lap"]) = lap;

         if (Session["fone"] != null)
        { fone = (string)(Session["fone"]); }
         else
             (Session["fone"]) = fone; 

        chargeLabel.Text = totalCharge.ToString("c");
        compLabel.Text = comp.ToString();
        laptopLabel.Text = lap.ToString();
        phoneLabel.Text = fone.ToString();

    }

    protected void confirmButton_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into [Order] (Computer, Laptop, Phone, TotalCharge) values(@Computer, @Laptop, @Phone, @TotalCharge)", con);
            cmd.Parameters.AddWithValue("@Computer", Session["comp"].ToString());
            cmd.Parameters.AddWithValue("@Laptop", Session["lap"].ToString());
            cmd.Parameters.AddWithValue("@Phone", Session["fone"].ToString());
            cmd.Parameters.AddWithValue("@TotalCharge", Session["TotalCharges"].ToString());
            cmd.ExecuteNonQuery();
            
        }
        Response.Redirect("CRUDorder.aspx");
        
    }
    protected void signButton_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("Home.aspx");
    }
}