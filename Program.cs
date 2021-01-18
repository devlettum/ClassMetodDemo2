using System;

namespace ClassMetodDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Batuhan";
            musteri1.Soyad = "ARIK";
            musteri1.TelNo = "5555555555";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Berkay";
            musteri2.Soyad = "Bozkurt";
            musteri2.TelNo = "54444444444";
            musteri2.Id = 2;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Samet";
            musteri3.Soyad = "Uçar";
            musteri3.TelNo = "53333333333";
            musteri3.Id = 3;

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);

            Console.WriteLine();

            musteriManager.Listele(musteriler);
           

        }
    }
}
