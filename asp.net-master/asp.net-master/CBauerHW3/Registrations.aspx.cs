using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registrations : System.Web.UI.Page
{
    const int Stress = 200;
    const int Time = 150;
    const int Supervision = 400;
    const int Negotiation = 500;

    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
       
    }
    protected void MyCalendar_DayRender(object sender, DayRenderEventArgs e)
    {
        if (e.Day.Date < System.DateTime.Today || e.Day.Date < System.DateTime.Today.AddDays(7) || e.Day.IsWeekend)
        {
            e.Day.IsSelectable = false;
        }
    }

    protected void sessionButtonList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void registerButton_Click(object sender, EventArgs e)
    {
        try
        {
            int charge = 0;
            int people = int.Parse(numberTextBox.Text);

            if (sessionButtonList.SelectedIndex == -1 || MyCalendar.SelectedDate.Date == DateTime.MinValue.Date)
            {
                Response.Write("<script>alert('Select a session and/or date on calendar!');</script>");
            }
            else if (sessionButtonList.SelectedIndex == 0)
            {
                charge = Stress * people;
                orderLabel.Text = "Name: " + nameTextBox.Text + " Session:" + sessionButtonList.Text + " " + MyCalendar.SelectedDate;
            }
            else if (sessionButtonList.SelectedIndex == 1)
            {
                charge = Time * people;
                orderLabel.Text = "Name: " + nameTextBox.Text + " Session:" + sessionButtonList.Text + " " + MyCalendar.SelectedDate;
            }
            else if (sessionButtonList.SelectedIndex == 2)
            {
                charge = Supervision * people;
                orderLabel.Text = "Name: " + nameTextBox.Text + " Session:" + sessionButtonList.Text + " " + MyCalendar.SelectedDate;
            }
            else if (sessionButtonList.SelectedIndex == 3)
            {
                charge = Negotiation * people;
                orderLabel.Text = "Name: " + nameTextBox.Text + " Session:" + sessionButtonList.Text + " " + MyCalendar.SelectedDate;

            }

            chargeLabel.Text = charge.ToString("c");
        }
        catch (Exception err)
        {
            orderLabel.Text = "<b>Message:</b> " + err.Message; 
        }
    }
    protected void clearButton_Click(object sender, EventArgs e)
    {
        nameTextBox.Text = "";
        numberTextBox.Text = "";
        sessionButtonList.ClearSelection();
        chargeLabel.Text = "";
        orderLabel.Text = "";
    }
}