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
        public int SaleId;
        ArrayList process = new ArrayList();

    

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
                         
                            Sale tran = new Sale(Convert.ToInt32(idText.Text), nameText.Text, Convert.ToInt32(sfText.Text), flooringBox.SelectedItem.ToString(), install.Checked);
                            Results.Items.Add("Material Charge: " + tran.M_Charge.ToString("c"));
                            Results.Items.Add("\nInstall Charge: " + tran.I_Charge.ToString("c"));
                            Results.Items.Add("\nTotal Charge: " + tran.Charge.ToString("c"));
                            tran.AreaLimit += OnAreaChecked;
                                tran.AreaProcess(); 
                           process.Add(tran);
                           if (tran.SaleDetails(tran) > 0)
                           {
                               MessageBox.Show("Success!");
                           }

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

        void OnAreaChecked(object sender, EventArgs e)
        {
            MessageBox.Show("Requested area exceeds 500 sq.feet. " +
            "Please check inventory and crew availability.");
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
     
        }

        private void noinstall_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void install_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
          
            SaleDBConnect sdb = new SaleDBConnect();
            SalesGrid.DataSource = sdb.GetSales();
        }

        private void SalesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idText.Text, out SaleId))
            {
                try
                {
                    Sale s = new Sale(Convert.ToInt32(idText.Text), nameText.Text, Convert.ToInt32(sfText.Text), flooringBox.SelectedItem.ToString(), install.Checked);

                    SaleDBConnect sdb = new SaleDBConnect();
                    sdb.DeleteSale(s);

                    MessageBox.Show("Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no matching id");
                }
            }
            else
                MessageBox.Show("Enter numeric data for the sale id", "Error");
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idText.Text, out SaleId))
            {
                try
                {
                   
            Sale s3 = new Sale(Convert.ToInt32(idText.Text), nameText.Text, Convert.ToInt32(sfText.Text), flooringBox.SelectedItem.ToString(), install.Checked);
            SaleDBConnect sdb2 = new SaleDBConnect();
             sdb2.UpdateSale(s3);
        
            MessageBox.Show("Update Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no matching id");
                }
            }
            else
                MessageBox.Show("Enter numeric data for the sale id", "Error");
        }
    }
}
