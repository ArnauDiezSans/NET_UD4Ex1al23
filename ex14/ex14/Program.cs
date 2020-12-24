using System;

namespace ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el radio del circulo:");
            double radio;
            radio = Convert.ToDouble(Console.ReadLine());
            double resultado=Math.Pow(Math.PI, 2)*radio;
            Console.WriteLine("Resultado:{0}", resultado);
        }
    }
}
