using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Shop : System.Web.UI.Page
{
    const int computer = 600;
    const int laptop = 400;
    const int phone = 200;
    int totalCharge;

    string comp="";
    string lap="";
    string fone="";


    protected void Page_Load(object sender, EventArgs e)
    {

        Session.Clear();
        if (IsPostBack && Session["comp"] != null)
        { comp = (string)(Session["comp"]); }

        if (IsPostBack && Session["lap"] != null)
        { lap = (string)(Session["lap"]); }

        if (IsPostBack && Session["fone"] != null)
        { fone = (string)(Session["fone"]); }

        if (IsPostBack && Session["TotalCharges"] != null)
        { totalCharge = Convert.ToInt32(Session["TotalCharges"]); }
    }

    protected void placeButton_Click(object sender, EventArgs e)
    {


        int totalcharge=0;
        int charge;
        if (computerCheckBox.Checked)
        {

            charge = computer;
            Session["comp"]=computerLabel.Text;
            totalcharge += charge;

        }

        if (laptopCheckBox.Checked)
        { 
            charge = laptop;
            Session["lap"] = laptopLabel.Text;
            totalcharge += charge;
        }

        if (phoneCheckBox.Checked)
        {
            charge = phone;
            Session["fone"] = phoneLabel.Text;
            totalcharge += charge;
        }

        Session["TotalCharges"] = totalcharge;


        Response.Redirect("Login.aspx"); 
    }
}