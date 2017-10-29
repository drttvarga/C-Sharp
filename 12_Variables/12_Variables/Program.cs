using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 3;
            Console.WriteLine("{0} + {1} = {2}", a, b, a+b);
            Console.WriteLine("{2} - {1} = {0}", a, b, a + b);

            double c = 2.3;
            double d = 4.2;
            Console.WriteLine("{0} + {1} = {2}", c, d, c + d);
            Console.WriteLine("{2} - {1} = {0}", c, d, c + d);
            Console.ReadKey();

        }
    }
}
