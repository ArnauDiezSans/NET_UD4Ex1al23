using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int x;
            int y;
            //Console.WriteLine("Introduce el primer numero:");
            //x = Console.ReadLine();
            x = 3;
            //Console.WriteLine("Introduce el segundo numero:");
            //y = Console.ReadLine();
            y = 5;
            if (x > y) {
                Console.WriteLine("El mayor es {0}", x);
            }
            else
            {
                if (y > x) 
                {
                    Console.WriteLine("El mayor es {0}", y);
                }
                else
                {
                    Console.WriteLine("Los numeros son iguales");
                }

            }
            

        }
    }
}
