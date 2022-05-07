using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class shirt
    {
       // public static int charge{get; set;}
        //public static string shirt_size { get; set; }
        //public static string extra_shirt_size { get; set; }
      //  string [] orders;
             
       // public int charge;
        private string id; 
        private string name;
        public string address;
        public string Address{ get; set; }
        public int quantity;
        public int size;
        public int regular=16;
        public int extra=18;
        public static int totalCharge { get; set; }

        public shirt(string id, string name, string address, int quantity, int size)
        {
            
            this.id = id;
            this.name = name;
            this.address = address;
            this.quantity = quantity;
            this.size = size;
        }

      //  public shirt(int quantity, int size) {
       //     this.quantity = quantity;
      //      this.size = size;
      //  }
            public int Charge(){
                int charge;
                charge = quantity * regular;
                 totalCharge+=charge;

                 return totalCharge;
                 
                
        }

            public int xCharge() {
                int charge;
            //    int totalcharge;
                charge = quantity * extra;
                totalCharge += charge;
                return totalCharge;
            }


        public override string ToString(){
            return " " + id + " " + name + " " + address + " " + quantity + " shirts for: $"+ totalCharge;

    }
}
}
