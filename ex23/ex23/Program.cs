using System;

namespace ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("APLICACION CALCULADORA INVERSA/n/nIntroduce el primer número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce la operación a realizar:");
            string operacion = Console.ReadLine();
            switch (operacion)
            {
                case "+":
                    Console.WriteLine("Resultado: {0}",num1 + num2);
                    break;
                case "-":
                    Console.WriteLine("Resultado: {0}", num1 - num2);
                    break;
                case "*":
                    Console.WriteLine("Resultado: {0}", num1 * num2);
                    break;
                case "/":
                    Console.WriteLine("Resultado: {0}", num1 / num2);
                    break;
                case "^":
                    Console.WriteLine("Resultado: {0}", Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num2)));
                    break;
                case "%":
                    Console.WriteLine("Resultado: {0}", num1 % num2);
                    break;
            }
        }
    }
}
