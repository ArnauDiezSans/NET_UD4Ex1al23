using System;

namespace ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el dia de la semana");
            string dia = Console.ReadLine();
            switch (dia)
            {
                case "Lunes":
                    Console.WriteLine("Entre semana");
                    break;
                case "Martes":
                    Console.WriteLine("Entre semana");
                    break;
                case "Miercoles":
                    Console.WriteLine("Entre semana");
                    break;
                case "Jueves":
                    Console.WriteLine("Entre semana");
                    break;
                case "Viernes":
                    Console.WriteLine("Entre semana");
                    break;
                case "Sábado":
                    Console.WriteLine("Fin de semana");
                    break;
                case "Domingo":
                    Console.WriteLine("Fin de semana");
                    break;
                default:
                    Console.WriteLine("Dia incorrecto");
                    break;
            }
        }
    }
}
