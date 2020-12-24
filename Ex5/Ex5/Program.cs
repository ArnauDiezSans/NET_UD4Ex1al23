using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
            int okei = 0;
            while (okei == 0) {
                Console.WriteLine("Introduce el día de la semana:");
                string dia = Console.ReadLine();
                if ((dia == "Lunes")| (dia == "Martes") | (dia == "Miercoles") | (dia == "Jueves") | (dia == "Viernes")) {
                    Console.WriteLine("{0} es un dia de entre semana", dia);
                    okei = 1;
                   }
                else {
                    if ((dia == "Sábado")| (dia == "Domingo")) {
                        Console.WriteLine("{0} es un día de fin de semana");
                        okei = 1;
                    }
                    else {
                        Console.WriteLine("Introduce un día entre Lunes y Domingo que esté bien escrito...");
                    }
                }
            }
        }
    }
}
