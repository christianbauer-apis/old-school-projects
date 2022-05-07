using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        ArrayList process = new ArrayList();
        Transaction p;

        ArrayList orders = new ArrayList();
        Transaction o;


        private void flooringBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Process_Click(object sender, EventArgs e)
        {
            try
            {
                if (idText.Text != "")
                {
                    if (nameText.Text != "")
                    {
                        if (sfText.Text != "")
                        {
                            if (flooringBox.Text != "")
                            {
                            Results.Items.Clear();
                         
                            if (install.Checked) {
                                Installation i = new Installation(nameText.Text, install_Date.Value, flooringBox.SelectedItem.ToString(), Convert.ToInt32(sfText.Text));

                                orders.Add(i);
                            }
                            Transaction tran = new Transaction(nameText.Text, Convert.ToInt32(sfText.Text), flooringBox.SelectedItem.ToString(), install.Checked);
                            Results.Items.Add("Material Charge: " + tran.M_Charge.ToString("c"));
                            Results.Items.Add("\nInstall Charge: " + tran.I_Charge.ToString("c"));
                            Results.Items.Add("\nTotal Charge: " + tran.Charge.ToString("c"));
                            process.Add(tran);
                           
                           }
                           else{MessageBox.Show("Please enter a floor type.", "Error");}

                        }
                        else { MessageBox.Show("Please enter a value.", "Error"); }
                    }
                    else { MessageBox.Show("Please enter a name.", "Error"); }
                }
                else { MessageBox.Show("Please enter an id.", "Error"); }
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Results_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idText_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void sfText_TextChanged(object sender, EventArgs e)
        {

        }

        private void install_CheckedChanged(object sender, EventArgs e)
        {
            if (install.Checked)
                install_Date.Visible = true;
        }

        private void noinstall_CheckedChanged(object sender, EventArgs e)
        {
            if (noinstall.Checked)
                install_Date.Visible = false;
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Results.Items.Clear();
            foreach (Transaction somepro in process)
            {
             Results.Items.Add(somepro.ToString());
            }
        }

        private void Display_Click(object sender, EventArgs e)
        {
            Results.Items.Clear();
            foreach (Installation someorder in orders)
                Results.Items.Add(someorder.ToString());
           
        }

        private void install_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
