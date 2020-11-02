using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class Program
    {
        static void Main()
        {
            // implicit function
            int salary = 45000;
            float f = salary;
            double d = salary;
            Console.WriteLine(d);
            Console.WriteLine("-----------------");
            // explicait function
            float price = 25.99f;
            int p = Convert.ToInt32(price);
            Console.WriteLine(p);
            Console.Read();
         }
    }
}
