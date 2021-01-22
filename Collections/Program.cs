using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Tuncay", "Ozan", "Caner", "Ali" };
            //Console.WriteLine(isimler[0);
            //Console.WriteLine(isimler[1]);

            List<string> isimler2 = new List<string> { "Tuncay", "Ozan", "Caner", "Ali" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Osman");
            Console.WriteLine(isimler2[4]);

            

        }
    }
}
