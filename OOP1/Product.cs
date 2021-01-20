﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Bu tip class'larda sadece özellik olur.
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //referans değişkeni olduğu için yani Id ile ilişkili olduğu için alt alta yazmak kod okunurluğu açısından iyi olur.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }


        //CRUD operasyonları genellikle özelliklerin olduğu class'lara gömülmez.

    }
}
