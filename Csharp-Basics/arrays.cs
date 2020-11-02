using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class arrays
    {
        static void Main()
        {
            {
                int size;
                Console.WriteLine("Enter the size of the array");
                size = Convert.ToInt32(Console.ReadLine());
                int i;
                int[] marks = new int[size];
                for (i = 0; i < size; i++)
                {
                    Console.WriteLine("enter the value", i);
                    marks[i] = Convert.ToInt32(Console.ReadLine());    
                }
                for (i = 0; i < size; i++)
                {
                    Console.WriteLine("index{0}: {1}",i, marks[i]);
                }
                    Console.Read(); 

            }
        }
    }
}
