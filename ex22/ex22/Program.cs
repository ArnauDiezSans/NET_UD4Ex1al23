using System;

namespace ex22
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "1234";
            int okei = 0;
            int intento = 1;
            while (okei == 0)
            {
                Console.WriteLine("Introduce la contraseña. (Intento {0})", intento);
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Enhorabuena");
                    okei = 1;
                }
                else
                {
                    Console.WriteLine("Error...");
                    intento++;
                }
            }
        }
    }
}
