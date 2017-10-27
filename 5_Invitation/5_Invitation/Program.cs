using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Invitation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(7, 1);
            Console.WriteLine("Birthday Party");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("16 september 2019 | 8:00 pm");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("********************************");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("***********************************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("You're invited to an unforgettable evening of partying!");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("***********************************************************");
            Console.ReadKey();
        }
    }
}
