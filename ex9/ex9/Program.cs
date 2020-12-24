using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int x = 1;
            while (x <= 100)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("Repetición {0}", x);
                }
                x++;
            }
        }
    }
}
