using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Time
    {
        // private variables atau field
        public int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;

        public int Year { get; set; }
        public int Month { get; set; }
        public int Date { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
            public Time(int year, int month, int date, int hour, int minute, int second)
        {
            this.Year = year;
            this.Month = month;
            this.Date = date;
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public void DisplayCurrentTime()
        {
            Console.WriteLine("Waktu sekarang : {0}", DateTime.Now.ToString());
        }
    }
}
