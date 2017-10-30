using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Celsius_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a temperature value in degree Celsius: ");
            string c = Console.ReadLine();
            double celsius = double.Parse(c);
            //Celsius to Fahrenheit: F = C * 1.8 + 32
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine("The temperature in Fahrenheit: {3}", celsius, 1.8, 32, fahrenheit);
            Console.ReadKey();
        }
    }
}
