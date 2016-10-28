using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossesBilarOchBågar
{
    class Vehicles
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int YearOfMake { get; set; }
        public int AmountOfProduct { get; set; }
        public string NewOrUsed { get; set; }
        public override string ToString()
        {

            return String.Format("Fordonet är:{0} Modell:{1} Tillverkare:{2} Årtal: {3} Antal:{4}",
               NewOrUsed,Model, Manufacturer, YearOfMake,AmountOfProduct);
        }


    }

 

}
