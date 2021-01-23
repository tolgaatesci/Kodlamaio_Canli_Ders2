using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class TuzelCustomer: Customer //coorporate //TuzelCustomer:Customer kullanımına, miras-intherance denir.
        //Musteri kapsar Tuzel ve Gercek müşteriyi. Musteri de olan her şey diğer çocuk olan (tüzel-gerçek) müşterilerde de vardır. 
        //Musteri ebeveyn oluyor. Customer yani. GerçekCustomer ve TüzelCustomer çocuk.
    {
        public string CompanyName { get; set; }
        public string VergiNo { get; set; }
    }
}
