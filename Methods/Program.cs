using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Elma";
            double price = 15;
            string description = "Amasya Elması";


            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Name = "Elma";
            urun1.Price = 15;
            urun1.Description = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Name = "Karpuz";
            urun2.Price = 80;
            urun2.Description = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.Description);
                Console.WriteLine(" ");
            }


            Console.WriteLine("--Metotlar---");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(urun1);
            sepetManager.Add(urun2);

            sepetManager.Add2("Armut", 12, "Yeşil Armut");



        }
    }
}
