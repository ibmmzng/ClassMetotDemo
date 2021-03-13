using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "Türkiye Cumhuriyeti";
            musteri1.KımlıkNo = "1234567891";
            musteri1.AdSoyad = "Hüseyin Şevki TOPUZ";
            musteri1.BankaHesabıVarmı = "EVET";
            musteri1.HesapNo = "Z1234T";
            Musteri musteri2 = new Musteri();
            musteri2.Id = "Türkiye Cumhuriyeti";
            musteri2.KımlıkNo = "24865217838";
            musteri2.AdSoyad = "Ali VELİ";
            musteri2.BankaHesabıVarmı = "EVET";
            musteri2.HesapNo = "Z4545T";
            Musteri musteri3 = new Musteri();
            musteri3.Id = "Türkiye Cumhuriyeti";
            musteri3.KımlıkNo = "78945641223";
            musteri3.AdSoyad = "Kemal SUNAL";
            musteri3.BankaHesabıVarmı = "HAYIR";

            MusteriManager musteriManage = new MusteriManager();
            musteriManage.musteriEkle(musteri1);
            musteriManage.musteriListesi(musteri3);
            musteriManage.musteriListesi(musteri2);
            musteriManage.musteriListesi(musteri1);
            musteriManage.musteriSilme(musteri2);
        }
    }
}
