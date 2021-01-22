using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            MusteriManager manager = new MusteriManager();
           
            Musteri m1 = new Musteri();
            m1.id = 1;
            m1.ad = "Ali";
            m1.soyad = "Kemal"; 
            manager.Listele(m1);
            manager.Ekle(m1);
            manager.Sil(m1);
           

            Musteri m2 = new Musteri();
            m2.id = 2;
            m2.ad = "Can";
            m2.soyad = "Akar";
            manager.Listele(m2);
            manager.Ekle(m2);
            manager.Sil(m2);
    

            Musteri m3 = new Musteri();
            m3.id = 3;
            m3.ad = "Yahya";
            m3.soyad = "Demir";
            manager.Listele(m3);
            manager.Ekle(m3);
            manager.Sil(m3);
     


        }
    }
}
