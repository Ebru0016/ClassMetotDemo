using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
        //Method injection - Metoda enjekte etmek
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
         //Başvuran bilgilerini değerlendirme
         //KonutKredisiManager konutKredisiManager = new KonutKredisiManager();
         //konutKredisiManager.Hesapla();
         //Böyle olursa tüm başvuruları konut kredisi üzerinden alır.

            krediManager.Hesapla();
            loggerService.Log();
        }
        
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
