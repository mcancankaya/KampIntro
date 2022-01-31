using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {    
        T[] items;
        public MyList ()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //Geçiçi Olarak Elemanları Tutan dizi.
            
            items = new T[items.Length+1]; //Eleman Sayısını arttırdığımız kod
            
            for (int i = 0; i < tempArray.Length; i++)
            {//Geçiçi verilerimizi tekrardan ana dizimize aldığımız for döngüsü.
                items[i] = tempArray[i];
            }
            
            
            // dizinin son indeksine yeni elemanı ekliyoruz.
            items[items.Length - 1] = item;

        }

        public T[] GetItems()
        {
            return items;
        }
    }
}
