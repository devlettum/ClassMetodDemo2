using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo2
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("********MÜŞTERİ EKLENDİ********");
            Console.WriteLine("Eklenen müşterinin adı : {0} soyadı : {1} telefon numarası : {2}",musteri.Ad,musteri.Soyad,musteri.TelNo);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("********MÜŞTERİ SİLİNDİ********");
            Console.WriteLine("Silinen müşterinin adı : {0} soyadı : {1} telefon numarası : {2}", musteri.Ad, musteri.Soyad, musteri.TelNo);
        }
        public void Listele(Musteri[] musteri)
        {
            Console.WriteLine("################MÜŞTERİ LİSTELEME################");
            foreach (var item in musteri)
            {
                Console.WriteLine("\nMüşteri ID'si : " + item.Id);
                Console.WriteLine("Adı : "+item.Ad);
                Console.WriteLine("Soyadı : "+item.Soyad);
                Console.WriteLine("Telefon Numarası : "+item.TelNo);
            }
        }
    }
}
