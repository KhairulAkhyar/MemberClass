using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi=new Taxi();

            taxi.DriverName = "Akyar";
            taxi.OnDuty=false;
            taxi.NumPassenger=10;

            taxi.taxiinfo();
            taxi.antar();
            Console.ReadKey();
        }
    }
}
