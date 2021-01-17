using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enderol'a hoşgeldiniz");

            xs Urun1 = new xs();
            Urun1.a = "Resim Kalemi 2B";
            Urun1.Magaza = "Acar Kitapçılık";
            Urun1.Fiyat = 3;
            Urun1.Kalan = 68;

            xs Urun2 = new xs();
            Urun2.a = "Akıllı Telefon";
            Urun2.Magaza = "Berk İletişim";
            Urun2.Fiyat = 2000;
            Urun2.Kalan = 45;

            xs Urun3 = new xs();
            Urun3.a = "Laptop";
            Urun3.Magaza = "Ender Elektronik";
            Urun3.Fiyat = 4500;
            Urun3.Kalan = 9;

            xs[] urunler = new xs[] { Urun1, Urun2, Urun3, };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("ÜrÜn : " + urunler[i].a);
                Console.WriteLine("Mağaza : " + urunler[i].Magaza);
                Console.WriteLine("Fiyat : " + urunler[i].Fiyat + "TL");
                Console.WriteLine("Kalan Ürün : " + urunler[i].Kalan);
                Console.WriteLine("----------------------");
            }

            foreach (var x in urunler)
            {
                Console.WriteLine("Ürün : " + x.a);
                Console.WriteLine("Mağaza : " + x.Magaza);
                Console.WriteLine("Fiyat : " + x.Fiyat + "TL");
                Console.WriteLine("Kalan Ürün : " + x.Kalan);
                Console.WriteLine("----------------------");
            }

        }
        class xs
        {
            public string a { get; set; }
            public string Magaza { get; set; }
            public double Fiyat { get; set; }
            public int Kalan { get; set; }
        }
    }
}




