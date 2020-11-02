using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class MethodsEg1
    {
        void welcome()
        {
            Console.WriteLine("welcome all!!!");
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
            MethodsEg1 Eg1 = new MethodsEg1();
            Eg1.welcome();
            string Name = Eg1.Name();
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age:{0}", Eg1.Age());
            Console.WriteLine("Initial: {0}", Eg1.Initial());
            Console.Read();
             
        }
    }
}
