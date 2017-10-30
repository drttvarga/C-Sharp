using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Digit_request_v1
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
            int t = (s * 10 + r) * 2;
            Console.WriteLine("Your number is: {0}", t);

            Console.ReadKey();
        }
    }
}
