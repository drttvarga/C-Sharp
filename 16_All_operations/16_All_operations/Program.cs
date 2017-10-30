using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_All_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string s = Console.ReadLine();
            int a = int.Parse(s);
            Console.Write("Enter the second number: ");
            string r = Console.ReadLine();
            int b = int.Parse(r);
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
            Console.ReadKey();
        }
    }
}
