using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class Installation : Service
    {
        string Name { get; set; }
        DateTime InstallDate { get; set; }
        string material { get; set; }
        int Area { get; set; }
        Service s = new Service();

        public Installation(string name, DateTime installdate, string flooring, int area)
            
        {
            Name = name;
            InstallDate = installdate;
            material = flooring;
            squarefoot = area;
        }

        public int squarefoot
        {

            get
            {
                return Area;
            }
            set
            {
                List<Service> install = new List<Service>();

                if (value < 1)
                    throw new ArgumentException("area must be greater than 0!");

                else
                {
                    Area = value;
                    install.Add(s);
                }
            }
        }
            //newline is not working
        public override string ToString()
        {
            return "Name: " + Name + " Installation Date: " + InstallDate + " Flooring type: " + material + " sq/ft: " + Area;
        }

          
        
    }
}
