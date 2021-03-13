using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musteriEkle(Musteri birey)
        {
            Console.WriteLine("Eklenen Müşteri Bilgileri");
            Console.WriteLine(birey.Id);
            Console.WriteLine(birey.KımlıkNo);
            Console.WriteLine(birey.AdSoyad);
            Console.WriteLine(birey.BankaHesabıVarmı);
            Console.WriteLine(birey.HesapNo);
        }
        public void musteriSilme(Musteri birey)
        {
            Console.WriteLine("Silinen Müşteri Bilgileri");
            Console.WriteLine(birey.Id);
            Console.WriteLine(birey.KımlıkNo);
            Console.WriteLine(birey.AdSoyad);
            Console.WriteLine(birey.BankaHesabıVarmı);
            Console.WriteLine(birey.HesapNo);

        }
        public void musteriListesi(Musteri birey)
        {
            Musteri[] musteriler = new Musteri[] {birey};
            Console.WriteLine("--------Müsteri Listesi-----");
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine("Müşteri NO=" + i);
                Console.WriteLine(musteriler[i].Id);
                Console.WriteLine(musteriler[i].KımlıkNo);
                Console.WriteLine(musteriler[i].AdSoyad);
                Console.WriteLine(musteriler[i].BankaHesabıVarmı);
                Console.WriteLine(musteriler[i].HesapNo);
                Console.WriteLine("----------------------");
            }
        }
    }
}
