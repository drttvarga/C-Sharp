using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleOfScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
            Console.WriteLine("******************");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
            Console.WriteLine("* Dorottya Varga *");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
            Console.WriteLine("******************");
            Console.ReadKey();
        }
    }
}
