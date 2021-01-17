using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        List<Musteri> musteriler = new List<Musteri>();
        public void Ekle(Musteri musteri)
        {
            String mesaj = "\n\nTebrikler! Müşteri  başarıyla eklendi.";

            mesaj = mesaj + "\nMüşteri ID\t\t: " + musteri.MusteriID;
            mesaj = mesaj + "\nMüşteri Adı\t\t: " + musteri.MusteriAdi;
            mesaj = mesaj + "\nMüşteri Soyadı\t\t: " + musteri.MusteriSoyadi;
            mesaj = mesaj + "\nMüşteri Yaş\t\t: " + musteri.MusteriYas;
            mesaj = mesaj + "\nMüşteri Bakiye\t\t: " + musteri.MusteriBakiye;

            Console.WriteLine(mesaj);

            musteriler.Add(musteri);
        }

        public void Listele()
        {
            String mesaj = "Müşteri listesi:\n\n";
            foreach (Musteri musteri in musteriler)
            {
                mesaj = mesaj + "\nMüşteri ID\t: " + musteri.MusteriID;
                mesaj = mesaj + "\tMüşteri Adı\t: " + musteri.MusteriAdi;
                mesaj = mesaj + "\tMüşteri Soyadı\t: " + musteri.MusteriSoyadi;
                mesaj = mesaj + "\tMüşteri Yaş\t: " + musteri.MusteriYas;
                mesaj = mesaj + "\tMüşteri Bakiye\t: " + musteri.MusteriBakiye;
            }

            Console.WriteLine(mesaj);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla silindi. Müşteri Id : "+musteri.MusteriID);
            
        }
    }
        
}
