using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)//fonksiyona yani metoda parametre gönderiyoruz. Bu parametre değer olarak değil class kullanılarak oluşturulduğu için gelen değerin adresi geliyor kendisi değil.
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public void Test(int sayi)
        {
            sayi = 99;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
