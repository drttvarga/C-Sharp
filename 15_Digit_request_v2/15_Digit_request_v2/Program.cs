using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Digit_request_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", s);
            Console.Write("Enter the second number: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", r);
            Console.Write("Enter the third number: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", p);
            int t = s * 4 + r * 2 + p;
            Console.WriteLine("Your number is: {0}", t);
            Console.ReadKey();
        }
    }
}
