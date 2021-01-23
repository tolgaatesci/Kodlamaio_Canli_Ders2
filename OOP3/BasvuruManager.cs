using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediBaseManager kredimanager, ILoggerService loggerService)
        {
            //KonutKrediManager konutKrediManager3 = new KonutKrediManager();
            //konutKrediManager3.Hesapla(); //yaparsak tüm başvuruları konut kredisine göre yapmış oluruz. Sıkıntı. O yüzden IKrediBaseManager interface'i kullanırım.

            kredimanager.Hesapla();
            loggerService.Log(); //Method injection


        }

        public void KrediOnBilgilendirmesiYap(List<IKrediBaseManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
