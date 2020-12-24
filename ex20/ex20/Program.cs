using System;

namespace ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el numero de ventas a realizar:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 1;
            double total=0;
            while (y <= x)
            {
                Console.WriteLine("Introduce la venta {0}", y);
                total = total + Convert.ToDouble(Console.ReadLine());
                y++;
            }
            Console.WriteLine("El total de las ventas es: {0}", total);
        }
    }
}
