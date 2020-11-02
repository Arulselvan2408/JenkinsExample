using System;

namespace Csharp_Basics
{
    class TwoDimensional
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter the value of a and b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[a, b];
            int i, j;
            for (i=0; i<a; i++)
            {
                for (j=0;j<b; j++)
                {
                    Console.WriteLine("Enter {0} {1}", i,j);
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(" ");
                    
                }
                Console.WriteLine();
            }
            Console.Read();

        }
    }
}
