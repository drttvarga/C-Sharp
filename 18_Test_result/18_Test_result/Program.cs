using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Test_result
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your score: ");
            string s = Console.ReadLine();
            double score = double.Parse(s);
            Console.Write("Enter the maximum score: ");
            string m = Console.ReadLine();
            double max = double.Parse(m);
            double count = (score / max) * 100;
            double percent = count;
            Console.WriteLine("Your percent is: {1}%", count, percent);
            Console.ReadKey();
        }
    }
}
