using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class BoxingUnboxing
    {
        static void Main()
        {
            // value type
            int petrol = 100;
            // reference type
            object o = petrol;
            Console.WriteLine("boxing conversion{0}", o);

            // reference type into value type 
            string Diesel = "103";
                int Dprice = Convert.ToInt32(Diesel);
            Console.WriteLine(Dprice);
            Console.Read();

        }

    }
}
