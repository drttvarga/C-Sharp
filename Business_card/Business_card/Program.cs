using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_card
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************************");
            Console.Write("*");
            Console.SetCursorPosition(35, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("*");
            Console.SetCursorPosition(12,1);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Kiss Tamás");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.Write("*");
            Console.SetCursorPosition(35, 4);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*");
            Console.SetCursorPosition(2, 2);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Cím: ");
            Console.ResetColor();
            Console.Write("1088, Budapest Vas utca 18. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*");
            Console.SetCursorPosition(4, 3);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("E-mail: ");
            Console.ResetColor();
            Console.Write("kisstamas@gmail.com    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*");
            Console.SetCursorPosition(6, 4);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Telefon: ");
            Console.ResetColor();
            Console.WriteLine("0670/333-1919");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("*");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("***********************************");
            Console.ReadKey();
        }
    }
}
