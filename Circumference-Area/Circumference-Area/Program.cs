using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circumference_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //The area of a rectangle is given by: A = a * b  ('a' is the height and 'b' is the width)
            //The circumference is given by the formula: C = 2 * (a + b) ('a' is the height and 'b' is the width)

            Console.Write("Enter the height (a): ");
            string s = Console.ReadLine();
            int a = int.Parse(s);
            Console.Write("Enter the width (b): ");
            string d = Console.ReadLine();
            int b = int.Parse(d);
            int area = a * b;
            int circumference = 2 * (a + b);
            Console.WriteLine("A = a * b: {0} * {1} = {2}", a, b, area);
            Console.WriteLine("C = 2 * (a + b): {0} * ({1} + {2}) = {3}", 2, a, b, circumference);
            Console.ReadKey();
        }
    }
}
