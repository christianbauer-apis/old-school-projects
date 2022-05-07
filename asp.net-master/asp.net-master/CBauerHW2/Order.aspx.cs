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
    int currentCharge;
    int totalCharge;
    int revenue;
    int allCharges;
    ArrayList nameList = new ArrayList();
    ArrayList phoneList = new ArrayList();
    int pens, mugs, mice, frames;
  



    protected void Page_Load(object sender, EventArgs e)
    {
        
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
       
        
        if (ViewState["AllCharges"] != null)
        {

            totalCharge = Convert.ToInt32(ViewState["AllCharges"]);

        }
        else
        {
            allCharges = 0;
        }

        if (IsPostBack && Session["TotalCharges"] != null)
        { allCharges = Convert.ToInt32(Session["TotalCharges"]); }

        if (IsPostBack && Session["AllNames"] != null)
        { nameList = (ArrayList)(Session["AllNames"]); }

        if (IsPostBack && Session["AllNumbers"] != null)
        { phoneList = (ArrayList)(Session["AllNumbers"]); }

        if (IsPostBack && Session["Pens"] != null)
        { pens = Convert.ToInt32(Session["Pens"]); }

        if (IsPostBack && Session["Mouse Pad"] != null)
        { mice = Convert.ToInt32(Session["Mouse Pad"]); }

        if (IsPostBack && Session["Picture Frames"] != null)
        { frames = Convert.ToInt32(Session["Picture Frames"]); }

        if (IsPostBack && Session["Mugs"] != null)
        { mugs = Convert.ToInt32(Session["Mugs"]); }



      

    }

    protected void Page_PreRender(object sender, EventArgs e)
    {

        //Store summary values in the ViewState
        //ViewState["AllItems"] = totalQuantity;

        ViewState["AllCharges"] = totalCharge;

    }

    protected void completeOrderButton_Click(object sender, EventArgs e)
    {

    }

    protected void cmdStore_Click(object sender, EventArgs e)
    {
       
        HttpCookie cookie = Request.Cookies["Preferences"];
        if (cookie == null)
        {
            cookie = new HttpCookie("Preferences");
        }
        
        cookie["Name"] = nameTextBox.Text;
        cookie.Expires = DateTime.Now.AddDays(1);
        Response.Cookies.Add(cookie);
       
        orderLabel.Text = totalCharge.ToString("c");
        allCharges += totalCharge;
        Session["TotalCharges"] = allCharges;

        nameList.Add(nameTextBox.Text);
        phoneList.Add(phoneTextBox.Text);
    }

    protected void addOrderButton_Click(object sender, EventArgs e)
    {
       int quantity = int.Parse(quantityTextBox.Text);
       int calculate;
       
       // totalCharge = 0;
        Session["AllNames"] = nameList;
        Session["AllNumbers"] = phoneList;

        if (itemListBox.SelectedIndex == -1)
        {
            Response.Write("<script>alert('Enter a meal!');</script>");
        }
        else if (itemListBox.SelectedIndex == 0)
        {
           
            calculate = Pen * quantity;
            pens += quantity;
            totalCharge += calculate;
            //Session["TotalCharges"] = totalCharge;
            Session["Pens"] = pens;   
        }
         else if (itemListBox.SelectedIndex == 1)
           {
               
               calculate = Mouse_pad * quantity;
               totalCharge += calculate;
               mice += quantity;
              // Session["TotalCharges"] = totalCharge;
               Session["Mouse Pad"] = mice;
           }
           else if (itemListBox.SelectedIndex == 2)
           {
               
               calculate = Picture_Frame * quantity;
               frames += quantity;
               totalCharge += calculate;
              // Session["TotalCharges"] = totalCharge;
              Session["Picture Frames"] = frames;
           }
        else if (itemListBox.SelectedIndex == 3)
        {
          
           calculate = Mug * quantity;
           totalCharge += calculate;
           mugs += quantity;
          // Session["TotalCharges"] = totalCharge;
           Session["Mugs"] = mugs;
        }
     

    }
    protected void nameTextBox_TextChanged(object sender, EventArgs e)
    {

    }
protected void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
{

}
}