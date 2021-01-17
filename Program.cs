using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriID =  1;
            musteri1.MusteriAdi = "Ayşe";
            musteri1.MusteriSoyadi = "Yılmaz";
            musteri1.MusteriYas = 37;
            musteri1.MusteriBakiye = 158000;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriID = 2;
            musteri2.MusteriAdi = "Fatma";
            musteri2.MusteriSoyadi = "Sandal";
            musteri2.MusteriYas = 45;
            musteri2.MusteriBakiye = 12000;
            /*Musteri[] musteriler = new Musteri[] { musteri1 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriID);
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.MusteriYas);
                Console.WriteLine(musteri.MusteriBakiye);

            }*/
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("\n-----------------------------------------------------------------------------------------\n");
            musteriManager.Listele();
            Console.WriteLine("\n-----------------------------------------------------------------------------------------\n");
            musteriManager.Sil(musteri2);

        }
    }
}
