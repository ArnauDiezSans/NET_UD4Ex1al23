using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int x;
            int y;
            Console.WriteLine("Introduce el primer numero:");
            x = Console.ReadLine();
            Console.WriteLine("Introduce el segundo numero:");
            y = Console.ReadLine();
            if x > y {
                Console.WriteLine("El mayor es {0}", x);
            }
            else {
                Console.WriteLine("El mayor es {0}", y);
            }
        }
    }
}
