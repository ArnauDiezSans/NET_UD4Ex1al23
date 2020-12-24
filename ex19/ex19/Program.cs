using System;

namespace ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (x = 1; x <= 100; x++)
            {
                if ((x % 2 == 0) | (x % 3 == 0))
                {
                    Console.WriteLine("{0}", x);
                }
            }
        }
    }
}
