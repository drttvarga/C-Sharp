using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ColorHelp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string g = "green";
            Console.WriteLine("Itsy bitsy spider " + g);
            Console.ForegroundColor = ConsoleColor.Red;
            string r = "red";
            Console.WriteLine("Itsy bitsy spider " + r);
            Console.ForegroundColor = ConsoleColor.Yellow;
            string y = "yellow";
            Console.WriteLine("Itsy bitsy spider " + y);
            Console.ForegroundColor = ConsoleColor.Blue;
            string b = "blue";
            Console.WriteLine("Itsy bitsy spider " + b);
            Console.ForegroundColor = ConsoleColor.Magenta;
            string m = "magenta";
            Console.WriteLine("Itsy bitsy spider " + m);
            Console.ReadKey();
        }
    }
}
