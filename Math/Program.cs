using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(1,2);
            dortIslem.Bol(2,4);
            dortIslem.Cikar(4,5);
            
            Console.WriteLine("Hello World!");
        }
    }
}
