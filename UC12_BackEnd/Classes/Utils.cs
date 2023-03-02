using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC12_BackEnd.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write($"{texto}");
            for (var contador = 0; contador < 7; contador++)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write($"*");
                Thread.Sleep(500);
            }

            Console.ResetColor();
        }
    }




}