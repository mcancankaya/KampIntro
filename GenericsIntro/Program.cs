using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            isimler.Add("Can");
            isimler.Add("Mert");

            foreach (var item in isimler.GetItems())
            {
                Console.WriteLine(item);
            }
        }
    }
}
