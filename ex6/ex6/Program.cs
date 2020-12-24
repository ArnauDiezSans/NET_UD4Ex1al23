using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int precio;
            Console.WriteLine("Introduce el precio de tu producto");
            precio = Convert.ToInt32(Console.ReadLine());
            int okei = 0;
            string forma_pago="", cuenta="";
            while (okei == 0) {
                Console.WriteLine("Pago en Efectivo o Tarjeta?");
                forma_pago = Console.ReadLine();
                if ((forma_pago == "Tarjeta") | (forma_pago == "Efectivo"))
                {
                    okei = 1;
                }
                else
                {
                    Console.WriteLine("Intentalo de nuevo. Efectivo o Tarjeta?");
                }
            }
            if (forma_pago == "Tarjeta")
            {
                Console.WriteLine("Introduce el numero de cuenta");
                cuenta = Console.ReadLine();
            }
            Console.WriteLine("Precio:{0}, Forma de pago:{1}, Cuenta(solo para Tarjeta):", precio, forma_pago, cuenta);

        }
    }
}
