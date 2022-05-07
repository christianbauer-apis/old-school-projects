#pragma checksum "E:\asp.net\CBauerHW2\Order.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A90422D4D8B98D2D4BCA387AFA7621F4C5FE79A8"

#line 1 "E:\asp.net\CBauerHW2\Order.aspx.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;


public partial class Order : System.Web.UI.Page
{

    const int Pen = 14;
    const int Mouse_pad = 12; 
    const int Picture_Frame = 20;
    const int Mug = 16;
    int totalQuantity;
    int totalCharge=0;
    int revenue;
    ArrayList nameList = new ArrayList();
    ArrayList phoneList = new ArrayList();
  


    protected void Page_PreRender(object sender, EventArgs e)
    {

        //Store summary values in the ViewState
         ViewState["AllItems"] = totalQuantity;
        
        ViewState["AllCharges"] = totalCharge;

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;


        if (IsPostBack && Session["TotalCharges"] != null)
        { totalCharge = Convert.ToInt32(Session["TotalCharges"]); }

        if (IsPostBack && Session["AllNames"] != null)
        { nameList = (ArrayList)(Session["AllNames"]); }

        if (IsPostBack && Session["AllNumbers"] != null)
        { phoneList = (ArrayList)(Session["AllNumbers"]); }

        if (ViewState["AllCharges"] != null)
        {
            //totalItems = Convert.ToDouble(ViewState["AllItems"]);
            totalCharge = Convert.ToInt32(ViewState["AllCharges"]);

        }
        else
        {
           // totalItems = 0;
            totalCharge = 0;
        }

    }


    protected void cmdStore_Click(object sender, EventArgs e)
    {
        //SessionStateDemo2_v2
        //store name and phone
        int quantity = int.Parse(quantityTextBox.Text);
        int calculate = 0;
        orderLabel.Text = totalCharge.ToString("c");
        Session["TotalCharges"] = totalCharge;
        HttpCookie cookie = Request.Cookies["Preferences"];
        if (cookie == null)
        {
            cookie = new HttpCookie("Preferences");
        }

        cookie["Name"] = nameTextBox.Text;
        cookie.Expires = DateTime.Now.AddDays(1);
        Response.Cookies.Add(cookie);
        orderLabel.Text = totalCharge.ToString("c");

        if (itemListBox.SelectedIndex == -1)
        {
            Response.Write("<script>alert('Enter a meal!');</script>");
        }
        else if (itemListBox.SelectedIndex == 0)
        {

            calculate = Pen * quantity;
            totalQuantity += quantity;
              totalCharge += calculate;
            Session["TotalCharges"] = totalCharge;
            Session["Pens"] = totalQuantity;
        }
        else if (itemListBox.SelectedIndex == 1)
        {

            calculate = Mouse_pad * quantity;
              totalCharge += calculate;
            Session["TotalCharges"] = totalCharge;
            Session["Mugs"] = totalQuantity;
        }
        else if (itemListBox.SelectedIndex == 2)
        {

            calculate = Picture_Frame * quantity;

              totalCharge += calculate;
            Session["TotalCharges"] = totalCharge;
            Session["Picture Frames"] = totalQuantity;
        }
        else if (itemListBox.SelectedIndex == 3)
        {

            calculate = Mug * quantity;
             totalCharge += calculate;
             Session["TotalCharges"] = totalCharge;
            Session["Mugs"] = totalQuantity;
        }
      //  totalQuantity += quantity;
       // Session["Pens"] = totalQuantity;
        //totalCharge += calculate;
        //Session["TotalCharges"] = totalCharge;
    }

    protected void addOrderButton_Click(object sender, EventArgs e)
    {
//ViewState
        
        //add quantity for each item


        int quantity = int.Parse(quantityTextBox.Text);
        int calculate = 0;
        nameList.Add(nameTextBox.Text);
        phoneList.Add(phoneTextBox.Text);

       
       // Session["Picture Frames"] = quantity;
       // Session["Mugs"] = quantity;
       // Session["Mouse Pad"] = quantity;

        Session["AllNames"] = nameList;
        Session["AllNumbers"] = phoneList;

        if (itemListBox.SelectedIndex == -1)
        {
            Response.Write("<script>alert('Enter a meal!');</script>");
        }
        else if (itemListBox.SelectedIndex == 0)
        {
           
            calculate = Pen * quantity;
            totalQuantity += quantity;
            totalCharge += calculate;
            Session["TotalCharges"] = totalCharge;
            Session["Pens"] = totalQuantity;   
        }
         else if (itemListBox.SelectedIndex == 1)
           {
               
               calculate = Mouse_pad * quantity;
               totalCharge += calculate;
               Session["TotalCharges"] = totalCharge;
               Session["Mugs"] = totalQuantity;
           }
           else if (itemListBox.SelectedIndex == 2)
           {
               
               calculate = Picture_Frame * quantity;

               totalCharge += calculate;
               Session["TotalCharges"] = totalCharge;
               Session["Picture Frames"] = totalQuantity;
           }
        else if (itemListBox.SelectedIndex == 3)
        {
          
           calculate = Mug * quantity;
           totalCharge += calculate;
           Session["TotalCharges"] = totalCharge;
           Session["Mugs"] = totalQuantity;
        }
        totalQuantity += quantity;
        Session["Pens"] = totalQuantity;  
        //totalCharge += calculate; 
       // Session["TotalCharges"] = totalCharge;

    }
    protected void nameTextBox_TextChanged(object sender, EventArgs e)
    {

    }
protected void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
{

}
}

#line default
#line hidden
