using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Taxi
    {
        public string DriverName;
        public bool OnDuty;
        public int NumPassenger;

        static void Main(string[] args)
        {
            // membuat objek Taxi
            Taxi taxi = new Taxi();

            // pengesetan nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOutPassenger();

            Console.ReadKey();
        }

        
       
    }
}
