using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product urun) 
        {
            Console.WriteLine("Ürün sepete eklendi :" + urun.Name);
        }

        public void Add2(string productName, double price, string description)
        {
            Console.WriteLine("Ürün sepete eklendi :" + productName);
        }
    }
}
