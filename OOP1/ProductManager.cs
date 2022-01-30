using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //Encapsulation
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Eklendi : "+product.ProductName);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Ürün Silindi : "+product.ProductName);
        }
    }
}
