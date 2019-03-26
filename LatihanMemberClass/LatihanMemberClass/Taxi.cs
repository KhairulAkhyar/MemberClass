using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }
        
        public void taxiinfo(){
            Console.WriteLine("Nama          : {0}", DriverName);
            Console.WriteLine("OnDuty        : {0}", OnDuty ? "Yes" : "No");
            Console.WriteLine("NumPassenger  : {0}", NumPassenger);
            Console.WriteLine("Mengambil Penumpang");
}
        public void antar(){
            Console.WriteLine("Sedang Antar Penumpang");

}

    }
}