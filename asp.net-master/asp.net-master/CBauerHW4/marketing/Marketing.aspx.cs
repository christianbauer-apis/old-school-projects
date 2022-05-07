using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Web.Security;

public partial class Marketing : System.Web.UI.Page
{

    private string connectionString =
  WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            CreateList();
        }
    }
    private void CreateList()
    {
        Regiondropdown.Items.Clear();

        // Define the Select statement.
        // Three pieces of information are needed: the unique id,
        // and the first and last name.
        string selectSQL = "SELECT RegionID FROM Region";

        // Define the ADO.NET objects.
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        DataTable table = new DataTable();
        // Try to open database and read information.
        try
        {
            con.Open();
           
            //string query = "SELECT RegionID FROM Region";
            // For each item, add the author name to the displayed
            // list box text, and store the unique ID in the Value property.
            adapter.Fill(table);

            Regiondropdown.DataSource = table;
            Regiondropdown.DataValueField = "RegionID";
            Regiondropdown.DataBind();
            
        }
        catch (Exception err)
        {
            Descriptionlabel.Text = "Error reading list of names. ";
            Descriptionlabel.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }


    protected void Regiondropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectSQL;
        selectSQL = "SELECT * FROM Region ";
        selectSQL += "WHERE RegionID='" + Regiondropdown.SelectedItem.Value + "'";

        // Define the ADO.NET objects.
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        DataTable table = new DataTable();

        // Try to open database and read information.
        try
        {
            con.Open();

            //string query = "SELECT RegionID FROM Region";
            // For each item, add the author name to the displayed
            // list box text, and store the unique ID in the Value property.
            adapter.Fill(table);

         //   Descriptionlabel.DataSource = table;
          //  Descriptionlabel.DataValueField = "RegionID";
            Descriptionlabel.Text = table.Rows[0]["RegionDescription"].ToString();

          //  reader = cmd.ExecuteReader();
          //  reader.Read();

           // StringBuilder sb = new StringBuilder();
          //  sb.Append("Region: ");
          //  sb.Append(reader["RegionDescription"]);
           // sb.Append("<br />");
          //  Descriptionlabel.Text

         //   reader.Close();
        }
        catch (Exception err)
        {
            Descriptionlabel.Text = "Error getting description. ";
            Descriptionlabel.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }
    protected void signOutButton_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("~/Home.aspx");
    }
}