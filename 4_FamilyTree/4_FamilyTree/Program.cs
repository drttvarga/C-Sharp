using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FamilyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kis Pál (felesége: Nagy Borbála)");
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("|-  Kis József");
            Console.SetCursorPosition(1, 2);
            Console.WriteLine("|-+ Kis Aladár     (felesége: Piros Éva)");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("|- Kis István");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("|- Kis Pál");
            Console.ReadKey();
        }
    }
}
