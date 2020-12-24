using System;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el precio sin IVA");
            double precio = Convert.ToDouble(Console.ReadLine());
            const double IVA = 0.21;
            Console.WriteLine("El precio con 21% de IVA es: {0}", precio + precio * IVA);

        }
    }
}
