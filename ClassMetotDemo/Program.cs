using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "BİLİR";
            musteri1.Id = 234987;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ezgi";
            musteri2.Soyadi = "DENİZ";
            musteri2.Id = 987654;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Aylin";
            musteri3.Soyadi = "TINMAZ";
            musteri3.Id = 345671;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("XYX Bank Müşteri Takip");


            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Id);
                Console.WriteLine("..........");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekleme(musteri1);
            musteriManager.Ekleme(musteri2);
            musteriManager.Ekleme(musteri3);

            Console.WriteLine("..........");


            musteriManager.Listeleme(musteri1.Id, musteri1.Adi, musteri1.Soyadi);
            musteriManager.Listeleme(musteri2.Id, musteri2.Adi, musteri2.Soyadi);
            musteriManager.Listeleme(musteri3.Id, musteri3.Adi, musteri3.Soyadi);

            Console.WriteLine(".............");


            musteriManager.Silme(musteri1.Id, musteri1.Adi, musteri1.Soyadi);
            musteriManager.Silme(musteri2.Id, musteri2.Adi, musteri2.Soyadi);
            musteriManager.Silme(musteri3.Id, musteri3.Adi, musteri3.Soyadi);


            Console.WriteLine("............");
           




            
        }
    }
}
