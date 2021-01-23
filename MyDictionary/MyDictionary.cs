using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, T2>
    {
        T[] items;
        T2[] items2;

        public MyDictionary()
        {
            items = new T[0];
            items2 = new T2[0];
        }

        public void Add(T item, T2 item2) 
        {
            
            T[] tempArray = items;  
            items = new T[items.Length + 1]; 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

            T2[] tempArray2 = items2;
            items2 = new T2[items2.Length + 1];
            for (int i = 0; i < tempArray2.Length; i++)
            {
                items2[i] = tempArray2[i];
            }

            items2[items.Length - 1] = item2;
        }

        public void Goster()
        {

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i].ToString() + " " + items2[i]);

            }

        }

        
    }
}
