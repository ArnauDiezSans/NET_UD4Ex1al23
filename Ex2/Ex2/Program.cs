using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Introduce tu nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce tu ciudad");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Te llamas {0} y vives en {1}", nombre, ciudad);

        }
    }
}
