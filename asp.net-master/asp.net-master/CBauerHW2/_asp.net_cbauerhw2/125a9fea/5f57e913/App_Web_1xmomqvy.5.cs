#pragma checksum "E:\asp.net\CBauerHW2\Default.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76AEB22AA34484852DCDAB97EF86A6555C274FED"

#line 1 "E:\asp.net\CBauerHW2\Default.aspx.cs"
/*
 Project: ASP YouDesign
 
 Name: Christian Bauer 
  
  Description: A basic e-commerce website.
 * 
 * 
 * look at Faja's session pages.
 * create hyperlinks back to homepage
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["Preferences"];
        if (cookie == null)
        {
            welcomeLabel.Text = "<b>Welcome to ASP YouDesign</b>";
        }
        else
        {
            welcomeLabel.Text += "Welcome " + cookie["Name"] + " to ASP YouDesign";
        }
    }






}

#line default
#line hidden
