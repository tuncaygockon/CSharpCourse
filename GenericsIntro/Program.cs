using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Tuncay");

            Console.WriteLine(isimler);

            isimler.Add("Ozan");

            Console.WriteLine(isimler);


        }
    }
}
