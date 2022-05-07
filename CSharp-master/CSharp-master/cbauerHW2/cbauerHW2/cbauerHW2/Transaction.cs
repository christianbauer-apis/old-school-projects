using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class Transaction : ITransaction
    {
        public string Name { get; set; }
        public string Flooring { get; set; }
        public double Charge { get; set; }
        public double M_Charge { get; set; }
        public double I_Charge { get; set; }
        public double Area { get; set; }
        public bool Installation { get; set; }
        public DateTime InstallDate { get; set; }
        public string Id; 

        public Transaction(string name, int area, string floor, bool install) {
            
            Name = name;
            Area = area;
            Flooring = floor;
            Installation = install;
            Install_Charge();
            Material_Charge();
            TotalCharge();
            
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
            return  M_Charge = Area * rate;

      }
      public void Install_Charge() {
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
      public override string ToString()
      {
         return "Name: " + Name + " Flooring type: " + Flooring + " Total Charge: "  + Charge.ToString("c");
}
    
    }
    class Transactions<T>
    {

       List<T> transaction { get; set; }
       
        

        public void addTransaction() 
        {
           // transaction = new Transaction[500];
            transaction = new List<T>();
            IEnumerable<T> ienum = transaction;
            List<T> add = ienum.ToList<T>();
      //       t.Add(new Transaction());
      //  }

    //    public IEnumerable<T> addTransaction()
  //      {
    //      return new List<T>();
        }

    }
}
