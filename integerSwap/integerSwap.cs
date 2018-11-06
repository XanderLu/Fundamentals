using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integerSwap
{
    public class integerSwap
    {
        public static string IntSwap(int a,int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"{a} {b}");
            return a+","+b;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\n\tIntegerSwap.Main()\n\t....continue...");
            Console.ReadKey();
            IntSwap(2, 4);
        }
    }
}
