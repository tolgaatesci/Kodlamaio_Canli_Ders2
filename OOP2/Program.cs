using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer1 = new Customer();
            //customer1.CustomerName = "Tolga";
            //customer1.CustomerSurname = "Ateşci";
            //customer1.Id = 1;
            //customer1.TcNo = "123";
            //customer1.CustomerNumber = "456";
            //customer1.CompanyName = "?"; //gerçek kişiyiz biz, tüzel değil bu veri sıkıntı yaratır programın ilerleyen süreçlerinde. Bu yüzden dağıttık ortak olan veya olmayan verileri iki class (TuzelCustomer-GercekCustomer) daha ekleyerek dağıttık.

            //İki nesnem var aslına biri gerçek biri tüzel o yüzden bunların verileri aynı sınıfta yer alması sıkıntı yaratır.  İkisi de müşteri ama birbirlerinin yerine kullanılamazlar.

            GercekCustomer customer1 = new GercekCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "123";
            customer1.CustomerName = "Tolga";
            customer1.CustomerSurname = "Ateşci";
            customer1.TcNo = "456";

            TuzelCustomer customer2 = new TuzelCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "798";
            customer2.CompanyName = "Kodlama.io";
            customer2.VergiNo = "4568";

            Customer customer3 = new GercekCustomer(); //gördüğümüz gibi Customer, GercekCustomer ve TuzelCustomer sınıflarını da tutabiliyor.
            Customer customer4 = new TuzelCustomer(); //Musteri class'ı hem gerçek müşterinin referansını(adresini) tutabiliyor hem de tüzel müşterinin referansını tutabiliyor.
            //Böylece CustomerManager'de hem gerçek müşteri için hem de tüzel müşteriyi metotlarda kullanabilirim.
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
