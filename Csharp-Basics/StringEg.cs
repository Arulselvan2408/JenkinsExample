using System;


namespace Csharp_Basics
{
    class StringEg
    {static void Main()
        {
            String FirstName = "Arulselvan";
            Console.WriteLine("length of the string{0}", FirstName.Length);
            Console.WriteLine("Converting to UpperCase{0}", FirstName.ToUpper());
            Console.WriteLine("contains {0}", FirstName.Contains("sel"));
            Console.WriteLine("Index of s {0}", FirstName.IndexOf("s"));
            Console.WriteLine("Check the end letter {0}", FirstName.EndsWith("n"));
            Console.WriteLine("spilit into {0}", FirstName.Split());
            Console.Read();
        }
    }
}
