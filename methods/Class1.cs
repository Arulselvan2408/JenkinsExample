using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Class1
    {
        static void welcome()
            {
            Console.WriteLine("welcome all!");
            }
        string Name()
        {
            return "Arulselvan";
        }
        int Age()
        {
            return 23;
        }
        char Initial()
        {
            return 'B';
        }

        static void Main()
        {
            welcome();
            Class1 obj = new Class1();
            Console.WriteLine("Initial:{0}",obj.Initial());
            Console.WriteLine("Name:{0}", obj.Name());
            Console.WriteLine("Age:{0}", obj.Age());
        }

    }
}
