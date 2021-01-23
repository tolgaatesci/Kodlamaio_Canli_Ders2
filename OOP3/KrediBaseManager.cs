using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediBaseManager //eğer bir sınıf, bu interface'i kullanırsa, o kod bloğu aşağıdaki metotları (operasyonları) da içermelidir.
    {//interface yazım kuralı olarak başında I ile başlar.
        //interface içinde kuralları içerir. İlişkilendirdiğin class'larda bu şablonu kullanarak işi organize eder.
        //interface bizim için şablon demek, yani IKrediBaseManager'i ebeveyn olarak ilişkilendirdiğimiz class'lar bu void hesapla, void sorgula şablonlarını içermelidir.
        void Hesapla();
        void Sorgula();

        //interface'leri birbirinin alternatifi olan ancak kod içi farklılıkları olan durumlar için kullanırız. 
        

        
    }
}
