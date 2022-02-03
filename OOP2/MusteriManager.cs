using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İş sınıfları // Business Classes
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            
            Console.WriteLine("Müşteri Eklendi : "+musteri.MusteriNo);
        }
    }
}
