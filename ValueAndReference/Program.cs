﻿using System;

namespace ValueAndReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 30;

            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 4, 5, 6 };
            sayilar1 = sayilar2;
            sayilar2[0] = 10;
            Console.WriteLine(sayilar1[0]);
            

        }
    }
}
