using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ValuesFromKeyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            //First number
            Console.Write("Enter the first number: ");
            string s = Console.ReadLine();
            int a = int.Parse(s);
            //Second number
            Console.Write("Enter the second number: ");
            string p = Console.ReadLine();
            int b = int.Parse(p);
            // calculations
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            Console.WriteLine("{2}-{1}={0}", a, b, a + b);
            Console.ReadKey();

            //Counting with fractional numbers
            //First number
            Console.Write("Enter the first number: ");
            string z = Console.ReadLine();
            double c = double.Parse(z);
            //Second number
            Console.Write("Enter the second number: ");
            string r = Console.ReadLine();
            double d = double.Parse(r);
            // calculations
            Console.WriteLine("{0}+{1}={2}", c, d, c + d);
            Console.WriteLine("{2}-{1}={0}", c, d, c + d);
            Console.ReadKey();
        }
    }
}
