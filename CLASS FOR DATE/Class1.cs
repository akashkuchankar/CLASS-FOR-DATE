using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_FOR_DATE
{
    internal class Class1
    {

      public class Date
        {
            private int day, year;
                string month;
            public void Add(int day,string month,int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }

            public string print()
            {
                return $"Date: {day}/{month}/{year}";
            }
        }
           
    }
}
