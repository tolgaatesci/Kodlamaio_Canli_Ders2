using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2 mobilyaya karşılık geliyor.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500; //500 TL
            product1.UnitInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35 }; //5 kırtasiyeye karşılık geliyor(CategoryId)

            //PascalCase yazım şekli: ProductManager. camelCase yazım şekli: productManager
            //case sensitive = c# büyük-küçük harf duyarlılığı gösterir.
            ProductManager productManager = new ProductManager();//örnek oluşturma = instance creation //ProductManager tipinde produckManager referans değeri için referans adresi oluşturuyoruz yani.
            productManager.Add(product1);
                        
            Console.WriteLine("-----------------------------------------------");

            productManager.Topla2(3, 6); //void ile oluşturduğun metotlarda, fonksiyon içindeki değere ulaşamazsın, yani Topla2 yaptın, o fonkisyon içinde kullandın ancak başka metotlarda veya main'de kullanamıyorsun çünkü çağramıyorsun sonucu.
            int toplamaSonucu = productManager.Topla(3,6);

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine(toplamaSonucu * 2);

            int sayi = 100;
            productManager.Test(sayi);
            //Console.WriteLine(sayi);
        }
    }
}
