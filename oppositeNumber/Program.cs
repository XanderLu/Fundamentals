using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppositeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine(oppositeNumber(2));
            Console.ReadKey();

        }

        public static int oppositeNumber(int x) => x -= x * 2;
    }
}
