using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();
            saya.Nim = "123456";
            saya.Nama = "Jono";
            saya.Ipk = 3.95f;

            kamu.Nim = "54321";
            kamu.Nama = "Joni";
            kamu.Ipk = 3.70f;

            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();
            Console.ReadKey();
        }
    }
}
