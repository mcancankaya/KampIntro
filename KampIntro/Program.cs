using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety - tip güvenli
            //Do not repeat yourself

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");
            }

            if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            else
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            Console.WriteLine("");
        }
    }
}
