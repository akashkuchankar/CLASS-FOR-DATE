using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_FOR_DATE
{
    internal class Program
    {
        static void Main(string[] args)
        {
          


            //student s1 = new student();
            //s1. add(345,"akash",68.46);
            //Console.WriteLine(s1.Print());

            //employee e1 = new employee();
            //e1.add(2, "akash", 4500000);
            //Console.WriteLine(e1.Print());

            //product p1 = new product();
            //p1.add(2, "mobile", 4500000);
            //Console.WriteLine(p1.Print());

            //course c1 =new course();
            //c1.add(2, ".net",10000);
            //Console.WriteLine(c1.Print()); 

            date d1 = new date();
            d1.add(10, "oct", 2022);
            Console.WriteLine(d1.Print());
        }
    }
}
