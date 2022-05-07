#pragma checksum "E:\asp.net\CBauerHW2\Admin.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D03466C492D40BF4C99F38FDF82853C57112C061"

#line 1 "E:\asp.net\CBauerHW2\Admin.aspx.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;


public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        ArrayList namesList = new ArrayList();
        ArrayList phonesList = new ArrayList();
       
        int pens=0;
        int mouse = 0;
        int picture = 0;
        int mug = 0;
        int totalCharge=0;

        if (Session["TotalCharges"] != null)
        { totalCharge = Convert.ToInt32(Session["TotalCharges"]); }
         
        if (Session["Pens"] != null)
        { pens = Convert.ToInt32(Session["Pens"]); }

        if (Session["Mouse Pad"] != null)
        { mouse = Convert.ToInt32(Session["Mouse Pad"]); }

        if (Session["Picture Frames"] != null)
        { picture = Convert.ToInt32(Session["Picture Frames"]); }

        if (Session["Mugs"] != null)
        { mug = Convert.ToInt32(Session["Mugs"]); }

       
        if (Session["AllNames"] != null)
        { namesList = (ArrayList)(Session["AllNames"]); }

        if (Session["AllNumbers"] != null)
        { phonesList = (ArrayList)(Session["AllNumbers"]); }

       

        for  (int i = 0; i < namesList.Count; i++)
        {
            if (namesList[i] != null)
                detailsListBox.Items.Add(namesList[i] + " : " + phonesList[i].ToString());
        }

      
        revenueLabel.Text = totalCharge.ToString("c");
        penLabel.Text = pens.ToString();
        mouseLabel.Text = mouse.ToString();
        pictureLabel.Text = mug.ToString();
        mugLabel.Text = picture.ToString();
    }
}

#line default
#line hidden
