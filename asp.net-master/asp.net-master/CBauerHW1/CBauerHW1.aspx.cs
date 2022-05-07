//Project: Catering website
// Name: Christian Bauer
// Description: displays event and the charge for the event.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    const int Prime_rib = 20;
    const int Chicken = 17;
    const int Pasta = 12;

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void CalcButton_Click(object sender, EventArgs e)
    {
        
        int guests;
       
       if (EventBox.Text == "")
           Response.Write("<script>alert('Enter event name!');</script>");


       try
       {

           guests = int.Parse(guestBox.Text);



           int calculate = 0;
           if (MenuBox.SelectedIndex == -1)
           {
               Response.Write("<script>alert('Enter a meal!');</script>");
           }
           else if (MenuBox.SelectedIndex == 0)
           {
               calculate = Prime_rib * guests;
               ChargeLabel.Text = calculate.ToString("c");
               EventLabel.Text = EventBox.Text;
           }
           else if (MenuBox.SelectedIndex == 1)
           {
               calculate = Chicken * guests;
               ChargeLabel.Text = calculate.ToString("c");
               EventLabel.Text = EventBox.Text;
           }
           else if (MenuBox.SelectedIndex == 2)
           {
               calculate = Pasta * guests;
               // move these inside the if statements
               ChargeLabel.Text = calculate.ToString("c");
               EventLabel.Text = EventBox.Text;
           }
       }
       catch
       {
           Response.Write("<script>alert('specify number of guests!');</script>");
       }
         
    }
  
    protected void MenuBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DisplayBox_TextChanged(object sender, EventArgs e)
    {

    }
    protected void EventBox_TextChanged(object sender, EventArgs e)
    {

    }
}