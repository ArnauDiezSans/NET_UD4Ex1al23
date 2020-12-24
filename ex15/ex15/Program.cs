using System;

namespace ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Es divisible por 2");
            }
            else
            {
                Console.WriteLine("No es divisible por 2");
            }
        }
    }
}
