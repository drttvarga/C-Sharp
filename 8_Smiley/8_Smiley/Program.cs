using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Smiley
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eyes
            Console.SetCursorPosition(1, 0);
            Console.Write("*");
            Console.SetCursorPosition(3, 0);
            Console.WriteLine("*");
            //Mouth
            Console.WriteLine("*");
            Console.SetCursorPosition(1, 2);
            Console.WriteLine("***");
            Console.SetCursorPosition(4, 1);
            Console.WriteLine("*");
            Console.ReadKey();
            Console.Clear();

            //Eyes
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("*");
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("*");
            Console.SetCursorPosition(4, 0);
            Console.WriteLine("*");
            Console.SetCursorPosition(4, 1);
            Console.WriteLine("*");
            //Mouth
            Console.WriteLine("*"); //cursor position (2, 1)
            Console.SetCursorPosition(1, 3);
            Console.WriteLine("*");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("***");
            Console.SetCursorPosition(6, 2);
            Console.WriteLine("*");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("*");

            Console.ReadKey();

        }
    }
}
