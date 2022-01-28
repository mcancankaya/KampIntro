using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2};
            Console.WriteLine("--- Ürün Listesi ---");
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün adı : "+urun.Adi+"\nÜrün fiyati : "+urun.Fiyati+"\nÜrün Açıklaması : "+urun.Aciklama);
                Console.WriteLine("--- --- --- --- --- ---");
            }

            Console.WriteLine("----- Metotlar -----");

            //instance - Class Örneği
            //Encapsulation 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            Console.WriteLine("Hello World!");
        }
    }
}

//Dont repeat yourself--DRY -- CleanCode -- Best Practice

