using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
   
    class Sale
    {
        SaleDBConnect sdb = new SaleDBConnect();

        public int SalesID { get; set; }
        public string Name { get; set; }
        public string Flooring { get; set; }
        public double Charge { get; set; }
        public double M_Charge { get; set; }
        public double I_Charge { get; set; }
        public int Area { get; set; }
        public bool Installation { get; set; }
        

        public event EventHandler AreaLimit;

        public Sale() 
        {
 
        }
        public Sale(int Salesid, string name, int area, string floor, bool install)
        {
            SalesID = Salesid;
            Name = name;
            Area = area;
            Flooring = floor;
            Installation = install;
            Install_Charge();
            Material_Charge();
            TotalCharge();
        }

        public string AreaProcess()
        {
            if (Area > 500)
                RaiseAreaInfo(EventArgs.Empty);

            return "";
        }

        protected virtual void RaiseAreaInfo(EventArgs e)
        {
            EventHandler Arealimit = AreaLimit;
            if (Arealimit != null)
            {
                Arealimit(this, e);
            }
        }


        public double Material_Charge()
        {
            double rate = 0;
            if (Flooring == "Hardwood")
                rate = 8;
            else if (Flooring == "Carpet")
                rate = 3;
            else if (Flooring == "Laminate")
                rate = 1.5;
            else if (Flooring == "Tile")
                rate = 12;
            return M_Charge = Area * rate;

        }
        public void Install_Charge()
        {
            int install = 20;

            if (Installation == true)
                I_Charge = Area * install;
            else if (Installation == false)
                I_Charge = 0;


        }
        public virtual void TotalCharge()
        {

            Charge = I_Charge + M_Charge;

        }

        public int SaleDetails(Sale s) 
        {
            return sdb.InsertSale(s);
        }


        public override string ToString()
        {
            return "Name: " + Name + " Flooring type: " + Flooring + " Total Charge: " + Charge.ToString("c");
        }

    }
}
