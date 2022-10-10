using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_FOR_DATE
{
    internal class date
    {
        private int Date;
        private string month;
        double year;

        public void add(int Date, string month, double year)
        {
            this.Date = Date;
            this.month = month;
            this.year = year;

        }
        public string Print()
        {
            return $"student:{Date}/{month}/{year}";
        }
    }
}
