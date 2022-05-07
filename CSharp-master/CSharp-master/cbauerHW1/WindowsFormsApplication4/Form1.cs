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

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList shirts = new ArrayList();
        shirt s1;

        private void process_button_Click(object sender, EventArgs e)
        {
          
            string address1 = address_textbox.Text;
            ShirtlistBox.Items.Clear();
            //radio button with associated variable c#
            //if (s1.address != address1)
         //   {
          

                if (small_radio.Checked)
                {
                    shirt s = new shirt(id_textbox.Text, name_textbox.Text, address_textbox.Text, Convert.ToInt32(shirt_textBox.Text), Convert.ToInt32(small_radio.Checked));
                    ShirtlistBox.Items.Add("total charge:"+ s.Charge().ToString("c"));
                    shirts.Add(s);

                }

                if (medium_radio.Checked)
                {
                    shirt s = new shirt(id_textbox.Text, name_textbox.Text, address_textbox.Text, Convert.ToInt32(shirt_textBox.Text), Convert.ToInt32(medium_radio.Checked));
                    ShirtlistBox.Items.Add("total charge:" + s.Charge().ToString("c"));
                    shirts.Add(s);
                }
                if (large_radio.Checked)
                {
                    shirt s = new shirt(id_textbox.Text, name_textbox.Text, address_textbox.Text, Convert.ToInt32(shirt_textBox.Text), Convert.ToInt32(large_radio.Checked));
                    ShirtlistBox.Items.Add("total charge:" + s.Charge().ToString("c"));
                    shirts.Add(s);
                }
                if (xlarge_radio.Checked)
                {
                    shirt s = new shirt(id_textbox.Text, name_textbox.Text, address_textbox.Text, Convert.ToInt32(shirt_textBox.Text), Convert.ToInt32(xlarge_radio.Checked));
                    ShirtlistBox.Items.Add("total charge:" + s.xCharge().ToString("c"));
                    shirts.Add(s);
                }
                if (xsmall_radio.Checked)
                {
                    shirt s = new shirt(id_textbox.Text, name_textbox.Text, address_textbox.Text, Convert.ToInt32(shirt_textBox.Text), Convert.ToInt32(xsmall_radio.Checked));
                    ShirtlistBox.Items.Add("total charge:" + s.xCharge().ToString("c"));
                    shirts.Add(s);
                }
          //  }
          //  else
          //  {
          //      
           // }
        }

        private void id_textbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void update_button_Click(object sender, EventArgs e)
        {
            string address = address_textbox.Text;
            ShirtlistBox.Items.Clear();
            foreach (shirt someshirt in shirts)
            {
                if (someshirt.address == address)
                    ShirtlistBox.Items.Add(someshirt.ToString());
            }
        }
            
        private void reports_button_Click(object sender, EventArgs e)
        {
            ShirtlistBox.Items.Clear();
            foreach (shirt someshirt in shirts)
                ShirtlistBox.Items.Add(someshirt.ToString());

        }



        }

}
