using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekleme (Musteri musteri )
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + "Müşteri başarılı bir şekilde eklendi.");

        }

        public void Listeleme (int musteriId , string musteriAdi , string musteriSoyadi)
        {
            Console.WriteLine(musteriId + " " + musteriAdi + " " + musteriSoyadi + " " + "Müşteriler başarılı bir şekilde listelendi.");

        }

        public void Silme (int musteriId , string musteriAdi , string musteriSoyadi)
        {
            Console.WriteLine(musteriId + " " + musteriAdi + " " + musteriSoyadi + " " + "Bilgili müşteriler başarılı bir şekilde silindi!");
        }
    }
}
