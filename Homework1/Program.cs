using System;

class Program
{
    static void Main(string[] args)
    {
        Urun urun1 = new Urun();
        urun1.markaAdi = "Tony Black";
        urun1.urunAdi = "Unisex Siyah Spor Ayakkabı";
        urun1.urunFiyat = 103.50;
        urun1.urunIndirim = true;

        Urun urun2 = new Urun();
        urun2.markaAdi = "Riccon";
        urun2.urunAdi = "Siyah Kırmızı Erkek Sneaker";
        urun2.urunFiyat = 119;
        urun2.urunIndirim = true;


        Urun urun3 = new Urun();
        urun3.markaAdi = "Hummel";
        urun3.urunAdi = "Unisex Spor Ayakkabı Eightyone Sneaker";
        urun3.urunFiyat = 299;
        urun3.urunIndirim = true;

        Urun urun4 = new Urun();
        urun4.markaAdi = "adidas";
        urun4.urunAdi = "Vs Pace Erkek Günlük Spor Ayakkabı";
        urun4.urunFiyat = 440;
        urun4.urunIndirim = false;

       

        Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4 };


        Console.WriteLine("TÜM ÜRÜNLER");


        foreach (var item in urunler)
        {
            Console.WriteLine(item.markaAdi + " " + item.urunAdi + " " + item.urunFiyat + " TL ");
        }

        Console.WriteLine(" ");


        Console.WriteLine("İNDİRİMDEKİ ÜRÜNLER");

        for (int a = 0; a < urunler.Length; a++)
        {   
            if(urunler[a].urunIndirim == true)
            {
                Console.WriteLine(urunler[a].markaAdi + " " + urunler[a].urunAdi + " " + urunler[a].urunFiyat + "TL");
                

            }
            
        }

        Console.WriteLine("");


        Console.WriteLine("İNDİRİMDE OLMAYAN ÜRÜNLER");

        int i = 0;
        while (i<=urunler.Length)
        {
            if(urunler[i].urunIndirim == false)
            {
                Console.WriteLine(urunler[i].markaAdi + " " + urunler[i].urunAdi + " " + urunler[i].urunFiyat + "TL");
                
            }
            
        }
    }
    class Urun
    {
        public string markaAdi { get; set; }
        public string urunAdi { get; set; }
        public double urunFiyat { get; set; }
        public bool urunIndirim { get; set; }



    }



}
