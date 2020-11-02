using System;


namespace methods
{
    class Eg2
    {
        void DisplayingUserDetails(string Cn, string City,string G, string mail)
        {
            Console.WriteLine("name{0}||city{1}||Gender{2}||Email{3}", Cn, City, G, mail);
        }
        int Total(int[] marray)
        {
            int sum = 0;
            for (int i=0; i<marray.Length; i++)
            {
                sum = sum + marray[i];
            }
            return sum;
        }
        static void Main()
        {
            string Cname, City,Gender, Email;
            int[]mark= new int[3]{ 80,79,56};
            Console.WriteLine("Enter the Customer Name:");
            Cname = Console.ReadLine();
            Console.WriteLine("Enter the City:");
            City = Console.ReadLine();
            Console.WriteLine("Enter the Gender:");
            Gender = Console.ReadLine();
            Console.WriteLine("Enter the Email:");
            Email = Console.ReadLine();

            Eg2 eg2 = new Eg2();
            eg2.DisplayingUserDetails(Cname, City, Email, Gender);
            Console.WriteLine("sum is:{0}", eg2.Total(mark));
            Console.Read();


        }
    }
}
