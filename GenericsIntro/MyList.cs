using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro //generic (kolleksiyon muhabbeti) oluşturuyoruz yani List generic'inin mantığını anlamaya ve sıfırdan yapmaya çalışıyoruz.
{
    class MyList<T> //programcı o an new derken hangi veri tipini kullandıysa T'de o an için o görevi görsün yani sadece string, int olmasın.
    {
        T[] items; //metodun dışında items listesi yazdığım için class'ın bütün metotlarından ulaşabilirim bu listeye.
        public MyList() //constructor, class'ı new'lersen burası, bu blok (public MyList()) otomatik olarak çalışıyor. ctor yazdım tab tab yaptım ve public MyList() oluştu.
        {
            items = new T[0]; //0 elemanlı dizim var artık tabi main code'da MyList<string> isimler = new MyList<string>(); dediğim anda.
        }
       
        public void Add(T item) //item=eleman
        {
            //tempArray=geciciDizi
            T[] tempArray = items; //items'in referans değeri kaybolmasın diye buraya atadım. Çünkü altta new'lediğim an items'in referans numarası uçar, onu kaybetmemek adına bu şekilde ekleme yapmamız gerekir.
            items = new T[items.Length + 1]; //items dizimin eleman sayısını bir arttırdım, mevcut ne ise bir tane daha eleman sayısı ekle.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
