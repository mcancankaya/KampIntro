using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "C# Kursu";
            string kurs2 = "Temel Programlama kursu";
            string kurs3 = "Java kursu";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //Array - Dizi

            string[] kurslar = new string[] { "C# Kursu", "Temel Programlama Kursu", "Java Kursu", "C/C++ Kursu", "HTML" };


            Console.WriteLine("\n-- Kurslar --");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + kurslar[i]);
            }

            Console.WriteLine("For : Sayfa Sonu - Footer\n");
            Console.WriteLine("-----------------------");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Foreach : Sayfa Sonu - Footer");
        }
    }
}
