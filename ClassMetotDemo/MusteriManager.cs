using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {


        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.ad + " " + musteri.soyad + " isimli kullanıcı eklenmiştir.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.ad + " " + musteri.soyad + " isimli kullanıcı silinmiştir.");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("İd :"+musteri.id);
            Console.WriteLine("Ad :"+musteri.ad);
            Console.WriteLine("Soyad :"+musteri.soyad);
        }
    }
}
