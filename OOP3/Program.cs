
using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        // I - İnterface

        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKredisiManager = new KonutKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager,fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager,tasitKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            

        }
    }
}
