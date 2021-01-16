using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //public void Ekle() - syntax yani yazım şekli bu şekildedir.. 
        //bir class'ın içinde birden fazla metot, fonksiyon olabilir.
        //class sonunda adı manager ile biten sınıflar var ise bunlar operasyon tutucuları diyebiliriz. Metotları sınıflara gömmüşlerdir yani.
        public void Ekle(Urun urun) //naming convention - yazım kuralı yani büyük ilk harfle başlıyoruz.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi :" + urun.Adi);
            //public void Ekle(Urun urun) yazımında urun paremetredir, Urun ise urun'un tipidir.
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi :" + urunAdi);
        }
    }
}
